using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using XML.Bank.CentralBankServiceReference;
using XML.Bank.Configuration;
using XML.Bank.Model;

namespace XML.Bank
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class BankService : IBankService, ICentralBankServiceCallback
    {
        private readonly BankConfigurationSection _config;
        private readonly CentralBankServiceClient _centralBankServiceClient;

        private static List<Account> _accounts;

        private static List<Client> _clients = new List<Client>()
        {
            new Client() { Name = "Luka", Accounts = _accounts.FindAll(x => x.AccountNumber.StartsWith("1112"))},
            new Client() { Name = "Petar", Accounts = _accounts.FindAll(x => x.AccountNumber.StartsWith("1123")) }
        };

        public BankService()
        {
            _config = ConfigurationManager.GetSection(BankConfigurationSection.DefaultSectionName) as BankConfigurationSection;
            _centralBankServiceClient = new CentralBankServiceClient(new InstanceContext(this));
            _centralBankServiceClient.RegisterBankClient(_config.BankId);

            _accounts = new List<Account>()
            {
                new Account() { AccountNumber = _config.BankId + "23", Currency ="EUR"},
                new Account() { AccountNumber = _config.BankId + "3213", Currency ="DIN"},
                new Account() { AccountNumber = _config.BankId + "2342", Currency = "EUR"}
            };
        }
        public AccountStatementResponse GetAccountStatement(AccountStatementRequest request)
        {
            var response = new AccountStatementResponse();
            var account = _accounts.Single(acc => acc.AccountNumber == request.AccountNumber);
            response.Number = account.Balance.ToString();
            return response;
        }

        public void PaymentAction(PaymentActionRequest request)
        {
            var account = request.RecipientAccountNumber;

            if (account.Substring(0, 3) == _config.BankId)
            {
                DoInternalBilling(request);
            }
            else
            {
                var mt103 = new MT103()
                {
                    Ammount = request.Ammount,
                    PayerAccount = request.PayerAccountNumber,
                    PayerBankAccountNumber = request.PayerAccountNumber,
                    RecipientAccount = request.RecipientAccountNumber,
                    RecipientBankAccountNumber = request.RecipientAccountNumber
                };

                _centralBankServiceClient.RTGSRequestAsync(mt103);
            }

            return;
        }

        private void DoInternalBilling(PaymentActionRequest request)
        {
            var paymentAccount = _accounts.Single(acc => acc.AccountNumber == request.PayerAccountNumber);
            var recipientAccount = _accounts.Single(acc => acc.AccountNumber == request.RecipientAccountNumber);

            paymentAccount.Balance -= (double)request.Ammount;
            recipientAccount.Balance += (double)request.Ammount;
        }

        public void MT103Callback(MT103 message)
        {
            var account = _accounts.Single(acc => acc.AccountNumber == message.RecipientAccount);
            account.Balance += (double)message.Ammount;
        }

        public void MT900CallBack(MT900 message)
        {
            var account = _accounts.Single(acc => acc.AccountNumber == message.PayerBankAccountNumber);
            account.Balance -= (double)message.Ammount;
        }

        public void MT910CallBack(MT910 message)
        {
        }
    }
}

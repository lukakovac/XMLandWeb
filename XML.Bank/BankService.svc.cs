using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using XML.Bank.Configuration;
using XML.Bank.Model;

namespace XML.Bank
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class BankService : IBankService
    {
        private readonly BankConfigurationSection _config;

        private static List<Account> _accounts = new List<Account>()
        {
            new Account() { AccountNumber = "11123456789", Currency ="EUR"},
            new Account() { AccountNumber = "111312312312", Currency ="DIN"},
            new Account() { AccountNumber = "11123456779", Currency = "EUR"}

        };

        private static List<Client> _clients = new List<Client>()
        {
            new Client() { Name = "Luka", Accounts = _accounts.FindAll(x => x.AccountNumber.StartsWith("1112"))},
            new Client() { Name = "Petar", Accounts = _accounts.FindAll(x => x.AccountNumber.StartsWith("1113")) }
        };

        public BankService()
        {
            _config = ConfigurationManager.GetSection(BankConfigurationSection.DefaultSectionName) as BankConfigurationSection;
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

            if (account.Substring(0,3) == _config.BankId)
            {
                DoInternalBilling(request);
            }
            else
            {

            }

            return;
        }

        public void RegisterNewClient(Client client)
        {

        }


        private void DoInternalBilling(PaymentActionRequest request)
        {
            var paymentAccount = _accounts.Single(acc => acc.AccountNumber == request.PayerAccountNumber);
            var recipientAccount = _accounts.Single(acc => acc.AccountNumber == request.RecipientAccountNumber);

            paymentAccount.Balance -= (double)request.Ammount;
            recipientAccount.Balance += (double)request.Ammount;
        }
    }
}

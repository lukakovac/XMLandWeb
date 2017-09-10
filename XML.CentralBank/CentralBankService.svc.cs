using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using XML.CentralBank.Model;

namespace XML.CentralBank
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CentralBankService : ICentralBankService
    {
        private Dictionary<string, IBankCallBack> _banks;

        public CentralBankService()
        {
            Console.WriteLine("Making Bank Service");
            _banks = new Dictionary<string, IBankCallBack>();
        }

        public bool RegisterBankClient(string bankId)
        {
            try
            {
                _banks.Add(bankId, OperationContext.Current.GetCallbackChannel<IBankCallBack>());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void RTGSRequest(MT103 requestMessage)
        {
            Console.WriteLine("REQUEST");
            try
            {
                var recipientBank = _banks[requestMessage.RecipientAccount.Substring(0, 3)];
                recipientBank.MT103Callback(requestMessage);
            }
            catch
            {
                return;
            }
            var payerBank = _banks[requestMessage.PayerAccount.Substring(0, 3)];

            if(payerBank != null)
            {
                payerBank.MT900CallBack(new MT900() { PayerBankAccountNumber = requestMessage.PayerBankAccountNumber, Ammount = requestMessage.Ammount });
            }
        }
    }
}

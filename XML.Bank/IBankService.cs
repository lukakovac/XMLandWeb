using System.ServiceModel;
using XML.Bank.Model;

namespace XML.Bank
{
    [ServiceContract]
    public interface IBankService
    {

        [OperationContract]
        void PaymentAction(PaymentActionRequest request);

        [OperationContract]
        AccountStatementResponse GetAccountStatement(AccountStatementRequest request);

        [OperationContract]
        void RegisterNewClient(Client client);
    }

}


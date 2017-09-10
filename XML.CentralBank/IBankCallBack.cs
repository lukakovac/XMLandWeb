using System.ServiceModel;
using XML.CentralBank.Model;

namespace XML.CentralBank
{
    [ServiceContract]
    public interface IBankCallBack
    {
        [OperationContract(IsOneWay = true)]
        void MT103Callback(MT103 message);

        [OperationContract(IsOneWay = true)]
        void MT900CallBack(MT900 message);

        [OperationContract(IsOneWay = true)]
        void MT910CallBack(MT910 message);
    }
}

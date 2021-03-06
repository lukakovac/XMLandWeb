﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using XML.CentralBank.Model;

namespace XML.CentralBank
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IBankCallBack))]
    public interface ICentralBankService
    {

        [OperationContract(IsOneWay = true)]
        void RTGSRequest(MT103 requestMessage);

        [OperationContract]
        bool RegisterBankClient(string bankId);
    }
}

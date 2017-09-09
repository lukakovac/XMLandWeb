using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XML.Bank.Model
{
    [DataContract]
    public class AccountStatementResponse
    {
        [DataMember]
        public string Number { get; set; }
    }
}
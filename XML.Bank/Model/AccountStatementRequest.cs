using System;
using System.Runtime.Serialization;

namespace XML.Bank.Model
{
    [DataContract]
    public class AccountStatementRequest
    {
        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public int OverviewNumber { get; set; }
    }
}
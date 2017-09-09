using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace XML.Bank.Model
{
    [DataContract]
    public class PaymentActionRequest
    {
        [DataMember]
        public string Payer { get; set; }

        [DataMember]
        public string PurposeOfPayment { get; set; }

        [DataMember]
        public string Recipient { get; set; }

        [DataMember]
        public DateTime DateOfOrder { get; set; }

        [DataMember]
        public DateTime DateOfCurrency { get; set; }

        [DataMember]
        public string PayerAccountNumber{ get; set; }

        [DataMember]
        public int ModeOfIndebtedness { get; set; }

        [DataMember]
        public string CallToTheNumberOfIndebtness { get; set; }

        [DataMember]
        public string RecipientAccountNumber { get; set; }

        [DataMember]
        public int ModelOfApproval { get; set; }

        [DataMember]
        public int CallToTheNumberOfApproval { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public bool IsUrgent { get; set; }

        [DataMember]
        public decimal Ammount { get; set; }
    }
}
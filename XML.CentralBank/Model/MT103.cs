using System.Runtime.Serialization;

namespace XML.CentralBank.Model
{
    [DataContract]
    public class MT103
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SWIFTPayerBank { get; set; }

        [DataMember]
        public string PayerBankAccountNumber { get; set; }

        [DataMember]
        public string SWIFTRecipientBank { get; set; }

        [DataMember]
        public string RecipientBankAccountNumber { get; set; }

        [DataMember]
        public string PayerAccount { get; set; }

        [DataMember]
        public string RecipientAccount { get; set; }

        [DataMember]
        public decimal Ammount { get; set; }
    }
}
using System.Runtime.Serialization;

namespace XML.CentralBank.Model
{
    [DataContract]
    public class MT910
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SWIFTRecipientBank { get; set; }

        [DataMember]
        public string RecipientBankAccountNumber { get; set; }

        [DataMember]
        public int MTMessageId { get; set; }

        [DataMember]
        public decimal Ammount { get; set; }
    }
}
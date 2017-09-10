using System.Runtime.Serialization;

namespace XML.CentralBank.Model
{
    [DataContract]
    public class MT900
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string SWIFTPayerBank { get; set; }

        [DataMember]
        public string PayerBankAccountNumber { get; set; }

        [DataMember]
        public int MTMessageId { get; set; }

        [DataMember]
        public decimal Ammount { get; set; }
    }
}
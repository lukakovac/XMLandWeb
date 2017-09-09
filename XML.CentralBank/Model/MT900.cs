namespace XML.CentralBank.Model
{
    public class MT900
    {
        public int Id { get; set; }

        public string SWIFTPayerBank { get; set; }

        public string PayerBankAccountNumber { get; set; }

        public int MTMessageId { get; set; }

        public decimal Ammount { get; set; }
    }
}
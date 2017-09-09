namespace XML.CentralBank.Model
{
    public class MT910
    {
        public int Id { get; set; }

        public string SWIFTRecipientBank { get; set; }

        public string RecipientBankAccountNumber { get; set; }

        public int MTMessageId { get; set; }

        public decimal Ammount { get; set; }
    }
}
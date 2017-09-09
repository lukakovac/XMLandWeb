namespace XML.CentralBank.Model
{
    public class MT103
    {
        public int Id { get; set; }

        public string SWIFTPayerBank { get; set; }

        public string PayerBankAccountNumber { get; set; }

        public string SWIFTRecipientBank { get; set; }

        public string RecipientBankAccountNumber { get; set; }

        public string PayerAccount { get; set; }

        public string RecipientAccount { get; set; }

        public decimal Ammount { get; set; }
    }
}
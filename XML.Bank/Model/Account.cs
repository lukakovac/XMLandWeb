namespace XML.Bank.Model
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public Client Client { get; set; }

        public string Currency { get; set; }

        public double Balance { get; set; }

        public double Reserved { get; set; }

        public double Total { get; set; }
    }
}
using System.Configuration;

namespace XML.Bank.Configuration
{
    public class BankConfigurationSection : ConfigurationSection
    {
        public static readonly string DefaultSectionName = "BankConfigurationSection";

        [ConfigurationProperty("BankName")]
        public virtual string BankName
        {
            get { return (string)this["BankName"]; }
            set { this["BankName"] = value; }
        }

        [ConfigurationProperty("BankId")]
        public virtual string BankId
        {
            get { return (string)this["BankId"]; }
            set { this["BankId"] = value; }
        }
    }
}
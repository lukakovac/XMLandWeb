using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XML.Company.Models
{
    public class Invoice
    {
        public string MessageId { get; set; }

        public string SupplierName { get; set; }

        public string SupplierAddress { get; set; }

        public string PIBSupplier { get; set; }

        public string BuyerName { get; set; }

        public string BuyerAddress { get; set; }

        public string BuyerAccount { get; set; }

        public string BillingDate { get; set; }

        public string GoodsValue { get; set; }
    }
}

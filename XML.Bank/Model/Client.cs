using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XML.Bank.Model
{
    public class Client
    {
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

    }
}
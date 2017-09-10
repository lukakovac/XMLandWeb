using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace XML.Company.Models
{
    public class XMLCompanyContext : DbContext
    {
        public XMLCompanyContext (DbContextOptions<XMLCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<XML.Company.Models.Invoice> Invoice { get; set; }
    }
}

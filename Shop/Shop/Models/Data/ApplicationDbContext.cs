using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shop.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ShopDbContext")
        {

        }
        public DbSet<Page> Pages { get; set; }
    }
}
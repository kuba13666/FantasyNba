using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarCMSWebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Performance> Performances { get; set; }
    }
}
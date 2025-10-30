using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1API.Models
{
    public class CustomerContext: DbContext
    {

        public DbSet<Customer> Customer { get; set; }
    }
}
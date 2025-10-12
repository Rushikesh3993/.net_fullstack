using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2Code_first_approach_entity.Models
{
    public class StudentContext : DbContext
    {

        public DbSet<Students> students { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace WebApplication2dot_net_corestart.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string confirmpass { get; set; }
    }
}

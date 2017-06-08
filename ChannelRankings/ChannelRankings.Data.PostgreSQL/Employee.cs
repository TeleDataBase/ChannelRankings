using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.PostgreSQL
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Company Company { get; set; }
        public DateTime HireDate { get; set; }
        public string Department { get; set; }
    }
}

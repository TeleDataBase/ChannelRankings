using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelRankings.Data.PostgreSQL
{
    public class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int YearFounded { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

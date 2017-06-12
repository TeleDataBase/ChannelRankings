using System.ComponentModel.DataAnnotations;

namespace Sqlitecodefirst.Models
{
    public class TvSeries
    {
        public int Id { get; set; }
        
        [MaxLength(40)]
        public string Name { get; set; }

        public int AnnualIncome { get; set; }

        [MaxLength(40)]
        [MinLength(4)]
        public string Genre { get; set; }

        public int? ChannelId { get; set; }
    }
}

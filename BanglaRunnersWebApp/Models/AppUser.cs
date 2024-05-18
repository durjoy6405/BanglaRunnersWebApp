using System.ComponentModel.DataAnnotations;

namespace BanglaRunnersWebApp.Models
{
    public class AppUser
    {
        [Key]
        public string id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}

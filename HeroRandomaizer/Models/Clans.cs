using System.ComponentModel.DataAnnotations;

namespace HeroRandomaizer.Models
{
    public class Clans
    {
        [Key]
        public int ClanId { get; set; }

        public string Name { get; set; }

        public int PowerLevel { get; set; } 
    }
}
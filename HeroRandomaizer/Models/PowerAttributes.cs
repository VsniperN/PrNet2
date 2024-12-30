using System.ComponentModel.DataAnnotations;

namespace HeroRandomaizer.Models
{
    public class PowerAttributes
    {
        [Key]
        public int AttributeId { get; set; }
        public string Attribute { get; set; }
    }
}
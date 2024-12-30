using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRandomaizer.Models
{
    public class HeroModel
    {
        [Key]
        public int HeroId { get; set; }

        public string Name { get; set; }

        public PowerAttributes PowerAttribute { get; set; }

        public Clans Clan { get; set; }
    }
}

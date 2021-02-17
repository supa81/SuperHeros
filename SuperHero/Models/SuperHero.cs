using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class Superhero
        
    {
        [Key]
        public int Id { get; set; }
        public string SuperHeroName { get; set; }
        public string SuperHeroAlterEgo { get; set; }
        public string Primarysuperheroability { get; set; }
        public string Secondarysuperheroability { get; set; }
        public string CatchPhrase { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CrewSize { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}

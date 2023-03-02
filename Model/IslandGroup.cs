using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greece.Model
{
    public class IslandGroup
    {
        public string Group { get; set; }
        public string GroupImage { get; set; }
        public string About { get; set; }
        public List<Island> Islands { get; set; }
    }

   
}

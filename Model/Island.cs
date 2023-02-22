using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greece.Model
{
    public class Island
    {
        public string Name { get; set; }
        public string IslandGroup { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public List<string> ImageGallery { get; set; }
        public double Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}

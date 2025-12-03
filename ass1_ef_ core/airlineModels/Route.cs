using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class Route
    {
        public int id { get; set; }
        public string destination { get; set; }
        public int distance { get; set; }
        public string origin {  get; set; }
        public string classification { get; set; }


        public ICollection<AirCraftRoute> AirCraftRoutes { get; set; } = new HashSet<AirCraftRoute>();
    }
}

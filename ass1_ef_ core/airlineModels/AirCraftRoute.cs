using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class AirCraftRoute
    {
        public int AirCraftId { get; set; }
        public AirCraft AirCraft { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int Duration { get; set; }  
        public decimal Price { get; set; }
    }
}

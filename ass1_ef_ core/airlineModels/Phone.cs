using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class Phone
    {
        public int Id { get; set; }

        public string Number { get; set; }

        
        public int AirlineId { get; set; }

 
        public Airline Airline { get; set; }
    }
}

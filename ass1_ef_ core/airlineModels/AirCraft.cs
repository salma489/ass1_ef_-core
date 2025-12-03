using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class AirCraft
    {
        public int Id { get; set; }
        public int capacity { get; set; }
        public string model { get; set; }
        public string? maj_pilot { get; set; }
        public string ?assistant { get; set; }
        public string ?host1 { get; set; }
        public string? host2 { get; set; }
        public int airlineid { get; set; }




        //[InverseProperty(nameof(Airline.aircrafts))]

        public Airline airCraftLine { get; set; }



        public Crew?crew { get; set; } 
       
       public ICollection<AirCraftRoute> AirCraftRoutes {  get; set; }= new HashSet<AirCraftRoute>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int db_year { get; set; }
        public int db_month { get; set; }
        public int db_day { get; set; }
        public string position { get; set; }

        public string gender { get; set; }
        public int al_id { get; set; }

      

        public int AirlineId { get; set; }

        [InverseProperty(nameof(airline.employees))]

        public Airline airline { get; set; }



        

    }
}

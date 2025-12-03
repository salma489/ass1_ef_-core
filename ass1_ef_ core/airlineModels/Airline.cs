using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
       public string ContactPerson { get; set; }

      

        [InverseProperty(nameof(Employee.airline))]

        public ICollection<Employee> employees { get; set; } = new HashSet<Employee>();

        public ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();


        public ICollection<AirCraft> aircrafts { get; set; }=new HashSet<AirCraft>();
        [InverseProperty(nameof(Transaction.airlinetransaction))]

        public  ICollection<Transaction> transactions { get; set; }=new HashSet<Transaction>();
    }
}

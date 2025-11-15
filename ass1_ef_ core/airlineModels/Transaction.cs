using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.airlineModels
{
    internal class Transaction
    {
        public int Id { get; set; }
        public int amount { get; set; }
        public string Description { get; set; }
        public string date { get; set; }
        public int al_id { get; set; }

    }
}

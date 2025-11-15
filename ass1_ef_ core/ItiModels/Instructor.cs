using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.ItiModels
{
    internal class Instructor
    {
        [Key]
        public int id {  get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public string address { get; set; }

        public int bonus { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal salary { get; set; }

        public int hour_rate { get; set;}
        public int dep_id { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.ItiModels
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FName { get; set; }

        public string LName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        [Column("Dep_Id")]
        public int DepId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.ItiModels
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        public int ins_Id { get; set; }


    }
}

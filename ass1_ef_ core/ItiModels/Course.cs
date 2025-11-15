using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.ItiModels
{
    internal class Course
    {
        [Key]
        public int id {  get; set; }
        [Required]
        public string name { get; set; }
        public int duration { get; set; }
        [MaxLength(100)]
        public string description { get; set; }
        public int top_id { get; set; }
    }
}

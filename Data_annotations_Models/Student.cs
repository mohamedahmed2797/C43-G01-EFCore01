using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Data_annotations_Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("FirstName")]
        public string FName { get; set; }
        [Column("LastName")]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(10,27)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}

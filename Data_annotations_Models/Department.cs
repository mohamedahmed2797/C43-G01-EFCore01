using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Data_annotations_Models
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Inst_Id { get; set; }
        public DateOnly HiringDate { get; set; }

    }
}

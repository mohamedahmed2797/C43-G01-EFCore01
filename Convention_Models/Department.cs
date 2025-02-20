using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Convention_Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Instructor_Id { get; set; }
        public DateOnly HiringDate { get; set; }

    }
}

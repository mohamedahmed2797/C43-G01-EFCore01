using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Convention_Models
{
    internal class Stud_Course
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public int Course_Id { get; set; }
        public char Grade { get; set; }

    }
}

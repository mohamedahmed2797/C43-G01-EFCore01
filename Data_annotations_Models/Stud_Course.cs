using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Data_annotations_Models
{
    internal class Stud_Course
    {
        public int Id{ get; set; }
        
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public char Grade { get; set; }
    }
}

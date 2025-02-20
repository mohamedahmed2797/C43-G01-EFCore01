using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Data_annotations_Models
{
    internal class Course_Inst
    {

        public int Id { get; set; }
        [Column("InstructorId")]
        public int Inst_ID { get; set; }
        
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_EFCore01.Data_annotations_Models
{
    internal class Topic
    {
        [Required]
        [Column("Topic_Id")]
        public int Id { get; set; }
        [Column("Topic_Name")]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("Group")]
    public class Group
    {
        public int ID { get; set; }
        [Column("IdSpecialty")]
        public int SpecialtyID { get; set; }
        public string NumberOfGroup { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

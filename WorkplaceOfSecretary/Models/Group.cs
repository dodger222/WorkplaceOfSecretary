using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    public class Group
    {
        public int ID { get; set; }
        public int IdSpecialty { get; set; }
        public string NumberOfGroup { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

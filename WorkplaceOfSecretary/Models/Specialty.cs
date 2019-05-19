using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    public class Specialty
    {
        public int ID { get; set; }
        public string NameOfSpecialty { get; set; }
        public string NumberOfSpecialty { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}

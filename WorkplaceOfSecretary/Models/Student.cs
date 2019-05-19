using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int IdGroup { get; set; }
        public float AverageScore { get; set; }
        public bool Foreigner { get; set; }

        public Group Group { get; set; }
        //public ICollection<Protocol> Protocols { get; set; }
    }
}

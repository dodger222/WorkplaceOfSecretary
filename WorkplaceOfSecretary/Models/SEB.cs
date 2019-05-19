using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("SEB")]
    public class SEB
    {
        public int ID { get; set; }
        public string NameOfSEB { get; set; }

        //public ICollection<Meeting> Meetings { get; set; }
        //public ICollection<Committee> Committees { get; set; }
    }
}

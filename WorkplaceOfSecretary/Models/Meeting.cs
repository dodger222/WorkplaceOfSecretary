using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("Meeting")]
    public class Meeting
    {
        public int ID { get; set; }
        [Column("IdSEB")]
        public int SebID { get; set; }
        public DateTime Date { get; set; }

        public SEB Seb { get; set; }
        //public ICollection<Protocol> Protocols { get; set; }
    }
}

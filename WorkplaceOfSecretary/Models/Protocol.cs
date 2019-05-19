using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("Protocol")]
    public class Protocol
    {
        public int ID { get; set; }
        [Column("IdStudent")]
        public int StudentID { get; set; }
        public string LastNameInDative { get; set; }
        public string LastNameInGenitive { get; set; }
        public string FirstNameInGenitive { get; set; }
        public string PatronymicInGenitive { get; set; }
        [Column("IdLeader")]
        public int LeaderID { get; set; }
        public string Theme { get; set; }
        public string Consultants { get; set; }
        public int MeetingID { get; set; }

        public Student Student { get; set; }
        public Employee Leader { get; set; }
        public Meeting Meeting { get; set; }
    }
}

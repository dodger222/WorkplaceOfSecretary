using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LastNameInGenitive { get; set; }
        [Column("IdDegree")]
        public int DegreeID { get; set; }
        [Column("IdRank")]
        public int RankID { get; set; }

        public Degree Degree { get; set; }
        public Rank Rank { get; set; }

        //public ICollection<Committee> CommitteesForChairperson { get; set; }
        //public ICollection<Committee> CommitteesForSecretary { get; set; }
        //public ICollection<Committee> CommitteesForMembers { get; set; }
        //public ICollection<Protocol> Protocols { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkplaceOfSecretary.Models
{
    [Table("Committee")]
    public class Committee
    {
        public int ID { get; set; }
        [Column("IdSEB")]
        public int SebID { get; set; }
        [Column("IdChairperson")]
        public int ChairpersonID { get; set; }
        [Column("IdSecretary")]
        public int SecretaryID { get; set; }
        [Column("IdMember1")]
        public int MemberOneID { get; set; }
        [Column("IdMember2")]
        public int MemberTwoID { get; set; }
        [Column("IdMember3")]
        public int MemberThreeID { get; set; }

        public SEB Seb { get; set; }
        public Employee Chairperson { get; set; }
        public Employee Secretary { get; set; }
        public Employee MemberOne { get; set; }
        public Employee MemberTwo { get; set; }
        public Employee MemberThree { get; set; }

    }
}

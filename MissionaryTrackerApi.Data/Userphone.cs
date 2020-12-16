using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("userphone")]
    public partial class Userphone
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userid")]
        public Guid? Userid { get; set; }
        [Column("phoneid")]
        public int? Phoneid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [ForeignKey(nameof(Phoneid))]
        [InverseProperty("Userphone")]
        public virtual Phone Phone { get; set; }
        [ForeignKey(nameof(Userid))]
        [InverseProperty("Userphone")]
        public virtual User User { get; set; }
    }
}

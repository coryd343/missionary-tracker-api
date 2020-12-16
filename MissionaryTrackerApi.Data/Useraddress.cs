using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("useraddress")]
    public partial class Useraddress
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userid")]
        public Guid? Userid { get; set; }
        [Column("addressid")]
        public int? Addressid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [ForeignKey(nameof(Addressid))]
        [InverseProperty("Useraddress")]
        public virtual Address Address { get; set; }
        [ForeignKey(nameof(Userid))]
        [InverseProperty("Useraddress")]
        public virtual User User { get; set; }
    }
}

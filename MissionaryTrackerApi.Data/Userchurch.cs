using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("userchurch")]
    public partial class Userchurch
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userid")]
        public Guid? Userid { get; set; }
        [Column("churchid")]
        public int? Churchid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [ForeignKey(nameof(Churchid))]
        [InverseProperty("Userchurch")]
        public virtual Church Church { get; set; }
        [ForeignKey(nameof(Userid))]
        [InverseProperty("Userchurch")]
        public virtual User User { get; set; }
    }
}

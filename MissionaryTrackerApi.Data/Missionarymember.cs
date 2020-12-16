using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("missionarymember")]
    public partial class Missionarymember
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("missionaryid")]
        public int? Missionaryid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }
        [Column("memberid")]
        public int? Memberid { get; set; }

        [ForeignKey(nameof(Memberid))]
        [InverseProperty("Missionarymember")]
        public virtual Member Member { get; set; }
        [ForeignKey(nameof(Missionaryid))]
        [InverseProperty(nameof(MissionaryGroup.Missionarymember))]
        public virtual MissionaryGroup Missionary { get; set; }
    }
}

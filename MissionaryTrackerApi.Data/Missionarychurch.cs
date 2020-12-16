using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("missionarychurch")]
    public partial class Missionarychurch
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("missionaryid")]
        public int? Missionaryid { get; set; }
        [Column("churchid")]
        public int? Churchid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [ForeignKey(nameof(Churchid))]
        [InverseProperty("Missionarychurch")]
        public virtual Church Church { get; set; }
        [ForeignKey(nameof(Missionaryid))]
        [InverseProperty(nameof(MissionaryGroup.Missionarychurch))]
        public virtual MissionaryGroup Missionary { get; set; }
    }
}

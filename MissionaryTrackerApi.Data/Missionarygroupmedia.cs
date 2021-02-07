using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("missionarygroupmedia")]
    public partial class Missionarygroupmedia
    {
        [Column("missionarygroupid")]
        public int Missionarygroupid { get; set; }
        [Column("mediaid")]
        public int Mediaid { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp(0) with time zone")]
        public DateTime? Datecreated { get; set; }
    }
}

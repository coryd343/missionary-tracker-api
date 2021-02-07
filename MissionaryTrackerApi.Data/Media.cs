using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("media")]
    public partial class Media
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("data")]
        public byte[] Data { get; set; }
        [Required]
        [Column("filename")]
        public string Filename { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp(0) with time zone")]
        public DateTime? Datecreated { get; set; }
    }
}

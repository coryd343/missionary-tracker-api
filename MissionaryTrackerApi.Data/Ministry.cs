using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("ministry")]
    public partial class Ministry
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }
    }
}

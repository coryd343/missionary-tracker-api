﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("phone")]
    public partial class Phone
    {
        public Phone()
        {
            Userphone = new HashSet<Userphone>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int Number { get; set; }
        [Required]
        public string Type { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [InverseProperty("Phone")]
        public virtual ICollection<Userphone> Userphone { get; set; }
    }
}

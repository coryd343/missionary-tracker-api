using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    public partial class MissionaryGroup
    {
        public MissionaryGroup()
        {
            Missionarychurch = new HashSet<Missionarychurch>();
            Missionarymember = new HashSet<Missionarymember>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? MinistryId { get; set; }
        public int? SendingChurchId { get; set; }

        [ForeignKey(nameof(SendingChurchId))]
        [InverseProperty(nameof(Church.MissionaryGroup))]
        public virtual Church SendingChurch { get; set; }
        [InverseProperty("Missionary")]
        public virtual ICollection<Missionarychurch> Missionarychurch { get; set; }
        [InverseProperty("Missionary")]
        public virtual ICollection<Missionarymember> Missionarymember { get; set; }
    }
}

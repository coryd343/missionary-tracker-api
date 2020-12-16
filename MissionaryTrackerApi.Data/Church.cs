using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    public partial class Church
    {
        public Church()
        {
            MissionaryGroup = new HashSet<MissionaryGroup>();
            Missionarychurch = new HashSet<Missionarychurch>();
            Userchurch = new HashSet<Userchurch>();
        }

        [Key]
        public int Id { get; set; }
        public string ChurchName { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? AddressId { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("Church")]
        public virtual Address Address { get; set; }
        [InverseProperty("SendingChurch")]
        public virtual ICollection<MissionaryGroup> MissionaryGroup { get; set; }
        [InverseProperty("Church")]
        public virtual ICollection<Missionarychurch> Missionarychurch { get; set; }
        [InverseProperty("Church")]
        public virtual ICollection<Userchurch> Userchurch { get; set; }
    }
}

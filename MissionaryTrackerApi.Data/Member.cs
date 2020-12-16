using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    public partial class Member
    {
        public Member()
        {
            Missionarymember = new HashSet<Missionarymember>();
        }

        [Key]
        public int Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Member")]
        public virtual User User { get; set; }
        [InverseProperty("Member")]
        public virtual ICollection<Missionarymember> Missionarymember { get; set; }
    }
}

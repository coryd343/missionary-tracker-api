using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    public partial class Address
    {
        public Address()
        {
            Church = new HashSet<Church>();
            Useraddress = new HashSet<Useraddress>();
        }

        [Key]
        public int Id { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Street2 { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }

        [InverseProperty("Address")]
        public virtual ICollection<Church> Church { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Useraddress> Useraddress { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionaryTrackerApi.Model
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

  }
}

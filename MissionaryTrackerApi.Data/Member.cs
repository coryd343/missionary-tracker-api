using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionaryTrackerApi.Model
{
    public class Member
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
  }
}

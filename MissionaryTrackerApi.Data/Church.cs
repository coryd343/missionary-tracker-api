using System;
using System.Collections.Generic;
using System.Text;

namespace MissionaryTrackerApi.Model
{
    public class Church
    {
        public Guid Id { get; set; }
        public string ChurchName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
  }
}

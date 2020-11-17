using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionaryTrackerApi.Model
{
    public class Missionary
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public string Field { get; set; }
        public string Website { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
  }
}

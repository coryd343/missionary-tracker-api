using System;
using System.Collections.Generic;
using System.Text;

namespace MissionaryTrackerApi.Data
{
  class Phone
  {
    public Guid Id { get; set; }
    public int Number { get; set; }
    public int TypeId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
  }
}

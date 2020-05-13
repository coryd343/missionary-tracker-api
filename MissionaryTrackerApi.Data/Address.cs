using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionaryTrackerApi.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        
    }
}

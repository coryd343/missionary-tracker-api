using System;
using System.Collections.Generic;
using System.Text;

namespace MissionaryTrackerApi.model
{
    class Church
    {
        public int id { get; set; }
        public string churchName { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string stateCode { get; set; }
        public int zipCode { get; set; }
        public string phone { get; set; }
    }
}

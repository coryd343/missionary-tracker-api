using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MissionaryTrackerApi.Model
{
    public class MissionaryTrackerDbContext : DbContext
    {
        public MissionaryTrackerDbContext(DbContextOptions<MissionaryTrackerDbContext> options) : base(options)
        {

        }
    }
}

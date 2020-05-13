using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MissionaryTrackerApi.Model;

namespace MissionaryTrackerApi.Model
{
    public class MissionaryTrackerDbContext : DbContext
    {
        //private IConfiguration Configuration;
        public MissionaryTrackerDbContext(DbContextOptions Options): base(Options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //=> optionsBuilder.UseNpgsql(this.Configuration.GetConnectionString("DbConnection2"));
            => optionsBuilder.UseNpgsql("Host=ec2-184-72-235-159.compute-1.amazonaws.com;Port=5432;Database=d68pu9oupelbt5;Username=nlyupgohfusitm;Password=5fd5df2f21918d75aae910c59ab5e965894580c2f980a19c1bb6cbb0433d7420;SSL Mode=Require;TrustServerCertificate=True;");

        public DbSet<Church> Church { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Missionary> Missionary { get; set; }
    }
}
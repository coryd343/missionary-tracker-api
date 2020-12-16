using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MissionaryTrackerApi.Data
{
    public partial class MissionaryTrackerDbContext : DbContext
    {
        public MissionaryTrackerDbContext()
        {
        }

        public MissionaryTrackerDbContext(DbContextOptions<MissionaryTrackerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Church> Church { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Ministry> Ministry { get; set; }
        public virtual DbSet<MissionaryGroup> MissionaryGroup { get; set; }
        public virtual DbSet<Missionarychurch> Missionarychurch { get; set; }
        public virtual DbSet<Missionarymember> Missionarymember { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Useraddress> Useraddress { get; set; }
        public virtual DbSet<Userchurch> Userchurch { get; set; }
        public virtual DbSet<Userphone> Userphone { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=ec2-184-72-235-159.compute-1.amazonaws.com;Port=5432;Database=d68pu9oupelbt5;Username=nlyupgohfusitm;Password=5fd5df2f21918d75aae910c59ab5e965894580c2f980a19c1bb6cbb0433d7420;SSL Mode=Require;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Church>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Church)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("address_id_fk");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("user_id_fk");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.MessageRecipient)
                    .HasForeignKey(d => d.Recipientid)
                    .HasConstraintName("recipient_user_id_fk");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSender)
                    .HasForeignKey(d => d.Senderid)
                    .HasConstraintName("sender_user_id_fk");
            });

            modelBuilder.Entity<Ministry>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<MissionaryGroup>(entity =>
            {
                entity.HasOne(d => d.SendingChurch)
                    .WithMany(p => p.MissionaryGroup)
                    .HasForeignKey(d => d.SendingChurchId)
                    .HasConstraintName("sending_church_fk");
            });

            modelBuilder.Entity<Missionarychurch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Church)
                    .WithMany(p => p.Missionarychurch)
                    .HasForeignKey(d => d.Churchid)
                    .HasConstraintName("church_id_fk");

                entity.HasOne(d => d.Missionary)
                    .WithMany(p => p.Missionarychurch)
                    .HasForeignKey(d => d.Missionaryid)
                    .HasConstraintName("missionary_id_fk");
            });

            modelBuilder.Entity<Missionarymember>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Missionarymember)
                    .HasForeignKey(d => d.Memberid)
                    .HasConstraintName("member_id_fk");

                entity.HasOne(d => d.Missionary)
                    .WithMany(p => p.Missionarymember)
                    .HasForeignKey(d => d.Missionaryid)
                    .HasConstraintName("missionary_group_id_fk");
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Useraddress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Useraddress)
                    .HasForeignKey(d => d.Addressid)
                    .HasConstraintName("address_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Useraddress)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("user_id_fk");
            });

            modelBuilder.Entity<Userchurch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Church)
                    .WithMany(p => p.Userchurch)
                    .HasForeignKey(d => d.Churchid)
                    .HasConstraintName("church_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userchurch)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("user_id_fk");
            });

            modelBuilder.Entity<Userphone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.Userphone)
                    .HasForeignKey(d => d.Phoneid)
                    .HasConstraintName("phone_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userphone)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("user_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

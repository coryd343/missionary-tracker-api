using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    public partial class User
    {
        public User()
        {
            Member = new HashSet<Member>();
            MessageRecipient = new HashSet<Message>();
            MessageSender = new HashSet<Message>();
            Useraddress = new HashSet<Useraddress>();
            Userchurch = new HashSet<Userchurch>();
            Userphone = new HashSet<Userphone>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Required]
        [Column("firstname")]
        public string Firstname { get; set; }
        [Required]
        [Column("lastname")]
        public string Lastname { get; set; }
        [Column("birthday", TypeName = "date")]
        public DateTime? Birthday { get; set; }
        [Column("createdby")]
        public Guid? Createdby { get; set; }
        [Column("datecreated", TypeName = "timestamp with time zone")]
        public DateTime? Datecreated { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Member> Member { get; set; }
        [InverseProperty(nameof(Message.Recipient))]
        public virtual ICollection<Message> MessageRecipient { get; set; }
        [InverseProperty(nameof(Message.Sender))]
        public virtual ICollection<Message> MessageSender { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Useraddress> Useraddress { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Userchurch> Userchurch { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Userphone> Userphone { get; set; }
    }
}

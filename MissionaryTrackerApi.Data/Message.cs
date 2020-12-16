using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MissionaryTrackerApi.Data
{
    [Table("message")]
    public partial class Message
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("senderid")]
        public Guid? Senderid { get; set; }
        [Column("recipientid")]
        public Guid? Recipientid { get; set; }
        [Column("messagetext")]
        public string Messagetext { get; set; }

        [ForeignKey(nameof(Recipientid))]
        [InverseProperty(nameof(User.MessageRecipient))]
        public virtual User Recipient { get; set; }
        [ForeignKey(nameof(Senderid))]
        [InverseProperty(nameof(User.MessageSender))]
        public virtual User Sender { get; set; }
    }
}

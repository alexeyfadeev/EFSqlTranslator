namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Message entity </summary>
    [Table("message", Schema="dbo")]
    public class Message
    {
        /// <summary> DateTime </summary>
        [Column("datetime")]
        public System.DateTime DateTime { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> IsRead </summary>
        [Column("is_read")]
        public bool IsRead { get; set; }
        
        /// <summary> ReceiverLogin </summary>
        [Column("receiver_login")]
        public string ReceiverLogin { get; set; }
        
        [ForeignKey(nameof(ReceiverLogin))]
        public virtual Contact Contact { get; set; }
        
        /// <summary> Sender </summary>
        [Column("sender")]
        public string Sender { get; set; }
        
        /// <summary> Text </summary>
        [Column("text")]
        public string Text { get; set; }
    }
}

namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Contact entity </summary>
    [Table("contact", Schema="dbo")]
    public class Contact
    {
        /// <summary> Email </summary>
        [Column("email")]
        public string Email { get; set; }
        
        /// <summary> Login </summary>
        [Column("login")]
        [Key()]
        public string Login { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> PartnerId </summary>
        [Column("partner_id")]
        public int PartnerId { get; set; }
        
        [ForeignKey(nameof(PartnerId))]
        public virtual Partner Partner { get; set; }
        
        /// <summary> Password </summary>
        [Column("password")]
        public string Password { get; set; }
        
        /// <summary> Phone </summary>
        [Column("phone")]
        public string Phone { get; set; }
        
        /// <summary> Position </summary>
        [Column("position")]
        public string Position { get; set; }
        
        /// <summary> Role </summary>
        [Column("role")]
        public int Role { get; set; }
    }
}

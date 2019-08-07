namespace Lama.ContractorPortal.Sql.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Partner entity </summary>
    [Table("partner", Schema="dbo")]
    public class Partner
    {
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> IsConfirmed </summary>
        [Column("is_confirmed")]
        public bool IsConfirmed { get; set; }
        
        /// <summary> LegalAddress </summary>
        [Column("legal_address")]
        public string LegalAddress { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> RegisterCode </summary>
        [Column("register_code")]
        public string RegisterCode { get; set; }
        
        /// <summary> Site </summary>
        [Column("site")]
        public string Site { get; set; }
        
        /// <summary> Tin </summary>
        [Column("tin")]
        public string Tin { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}

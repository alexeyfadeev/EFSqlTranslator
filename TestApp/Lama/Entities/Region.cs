namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Region entity </summary>
    [Table("region", Schema="dbo")]
    public class Region
    {
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}

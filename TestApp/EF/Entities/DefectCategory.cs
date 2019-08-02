namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> DefectCategory entity </summary>
    [Table("defect_category", Schema="public")]
    public class DefectCategory
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

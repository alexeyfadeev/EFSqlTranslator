namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> DefectType entity </summary>
    [Table("defect_type", Schema="public")]
    public class DefectType
    {
        /// <summary> DefectCategoryId </summary>
        [Column("defect_category_id")]
        public int DefectCategoryId { get; set; }
        
        [ForeignKey(nameof(DefectCategoryId))]
        public virtual DefectCategory DefectCategory { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}

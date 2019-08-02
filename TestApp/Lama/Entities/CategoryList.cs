namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> CategoryList entity </summary>
    [Table("category_list", Schema="dbo")]
    public class CategoryList
    {
        /// <summary> CategoryCode </summary>
        [Column("category_code")]
        [Key()]
        public long CategoryCode { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}

namespace RedAlliance.Orm.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> TextArray entity </summary>
    [Table("text_array", Schema="public")]
    public class TextArray
    {
        /// <summary> Data </summary>
        [Column("data")]
        public string[] Data { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        public int Id { get; set; }
    }
}

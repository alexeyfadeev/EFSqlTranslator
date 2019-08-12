namespace RedAlliance.Orm.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> TextRecord entity </summary>
    [Table("text_record", Schema="public")]
    public class TextRecord
    {
        /// <summary> Id </summary>
        [Column("id")]
        public int Id { get; set; }
        
        /// <summary> Text </summary>
        [Column("text")]
        public string Text { get; set; }
    }
}

namespace RedAlliance.Orm.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> NumberArray entity </summary>
    [Table("number_array", Schema="public")]
    public class NumberArray
    {
        /// <summary> Data </summary>
        [Column("data")]
        public int[] Data { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        public int Id { get; set; }
    }
}

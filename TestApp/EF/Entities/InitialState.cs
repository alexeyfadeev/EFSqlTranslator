namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> InitialState entity </summary>
    [Table("initial_state", Schema="public")]
    public class InitialState
    {
        /// <summary> Data </summary>
        [Column("data")]
        public string Data { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> StandId </summary>
        [Column("stand_id")]
        public int StandId { get; set; }
        
        [ForeignKey(nameof(StandId))]
        public virtual Stand Stand { get; set; }
        
        /// <summary> TagValues </summary>
        [Column("tag_values")]
        public System.Collections.Generic.Dictionary<string, string> TagValues { get; set; }
        
        /// <summary> TagValuesInt </summary>
        [Column("tag_values_int")]
        public System.Collections.Generic.Dictionary<string, string> TagValuesInt { get; set; }
    }
}

namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> ScenarioCommonHistory entity </summary>
    [Table("scenario_common_history", Schema="public")]
    public class ScenarioCommonHistory
    {
        /// <summary> DateTime </summary>
        [Column("datetime")]
        public System.DateTime DateTime { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> ScenarioText </summary>
        [Column("scenario_text")]
        public string ScenarioText { get; set; }
        
        /// <summary> StandId </summary>
        [Column("stand_id")]
        public int StandId { get; set; }
        
        [ForeignKey(nameof(StandId))]
        public virtual Stand Stand { get; set; }
    }
}

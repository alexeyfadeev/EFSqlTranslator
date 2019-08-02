namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> ScenarioHistory entity </summary>
    [Table("scenario_history", Schema="public")]
    public class ScenarioHistory
    {
        /// <summary> Data </summary>
        [Column("data")]
        public string Data { get; set; }
        
        /// <summary> DateTime </summary>
        [Column("datetime")]
        public System.DateTime DateTime { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> InitialStateId </summary>
        [Column("initial_state_id")]
        public int InitialStateId { get; set; }
        
        [ForeignKey(nameof(InitialStateId))]
        public virtual InitialState InitialState { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> ScenarioId </summary>
        [Column("scenario_id")]
        public int ScenarioId { get; set; }
        
        [ForeignKey(nameof(ScenarioId))]
        public virtual Scenario Scenario { get; set; }
        
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

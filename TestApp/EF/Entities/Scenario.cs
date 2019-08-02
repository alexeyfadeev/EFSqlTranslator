namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Scenario entity </summary>
    [Table("scenario", Schema="public")]
    public class Scenario
    {
        /// <summary> Data </summary>
        [Column("data")]
        public string Data { get; set; }
        
        /// <summary> Filename </summary>
        [Column("filename")]
        public string[] Filename { get; set; }
        
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

namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> ScenarioAutoSave entity </summary>
    [Table("scenario_autosave", Schema="public")]
    public class ScenarioAutoSave
    {
        /// <summary> AccountId </summary>
        [Column("account_id")]
        public int AccountId { get; set; }
        
        [ForeignKey(nameof(AccountId))]
        public virtual Account Account { get; set; }
        
        /// <summary> Data </summary>
        [Column("data")]
        public string Data { get; set; }
        
        /// <summary> DateTime </summary>
        [Column("datetime")]
        public System.DateTime DateTime { get; set; }
        
        /// <summary> ScenarioId </summary>
        [Column("scenario_id")]
        public int ScenarioId { get; set; }
        
        /// <summary> ScenarioText </summary>
        [Column("scenario_text")]
        public string ScenarioText { get; set; }
    }
}

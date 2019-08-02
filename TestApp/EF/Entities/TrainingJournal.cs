namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> TrainingJournal entity </summary>
    [Table("training_journal", Schema="public")]
    public class TrainingJournal
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
        
        /// <summary> Id </summary>
        [Column("id")]
        [Key()]
        public int Id { get; set; }
        
        /// <summary> ScenarioId </summary>
        [Column("scenario_id")]
        public int ScenarioId { get; set; }
        
        [ForeignKey(nameof(ScenarioId))]
        public virtual Scenario Scenario { get; set; }
        
        /// <summary> TrainingLog </summary>
        [Column("training_log")]
        public string TrainingLog { get; set; }
    }
}

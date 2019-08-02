namespace Fadeev.PostgresEfTest.Ef.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Trend entity </summary>
    [Table("trend", Schema="public")]
    public class Trend
    {
        /// <summary> Data </summary>
        [Column("data")]
        public System.Collections.Generic.Dictionary<string, string> Data { get; set; }
        
        /// <summary> Tag </summary>
        [Column("tag")]
        public string Tag { get; set; }
        
        /// <summary> TrainingJournalId </summary>
        [Column("training_journal_id")]
        public int TrainingJournalId { get; set; }
        
        [ForeignKey(nameof(TrainingJournalId))]
        public virtual TrainingJournal TrainingJournal { get; set; }
    }
}

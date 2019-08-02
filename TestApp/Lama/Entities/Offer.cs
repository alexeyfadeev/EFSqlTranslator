namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Offer entity </summary>
    [Table("offer", Schema="dbo")]
    public class Offer
    {
        /// <summary> Comment </summary>
        [Column("comment")]
        public string Comment { get; set; }
        
        /// <summary> ContractCode </summary>
        [Column("contract_code")]
        public string ContractCode { get; set; }
        
        [ForeignKey(nameof(ContractCode))]
        public virtual ContractList ContractList { get; set; }
        
        /// <summary> CreatorLogin </summary>
        [Column("creator_login")]
        public string CreatorLogin { get; set; }
        
        [ForeignKey(nameof(CreatorLogin))]
        public virtual Contact Contact { get; set; }
        
        /// <summary> DeferredPaymentDays </summary>
        [Column("deferred_payment_days")]
        public int DeferredPaymentDays { get; set; }
        
        /// <summary> Id </summary>
        [Column("id")]
        public int Id { get; set; }
        
        /// <summary> MarketingBudget </summary>
        [Column("marketing_budget")]
        public decimal MarketingBudget { get; set; }
        
        /// <summary> MinimumOrderPieces </summary>
        [Column("minimum_order_pieces")]
        public int MinimumOrderPieces { get; set; }
        
        /// <summary> MinimumOrderSum </summary>
        [Column("minimum_order_sum")]
        public decimal MinimumOrderSum { get; set; }
        
        /// <summary> MinimumOrderWeight </summary>
        [Column("minimum_order_weight")]
        public float MinimumOrderWeight { get; set; }
        
        /// <summary> MinimumQuantumOfSupplyPieces </summary>
        [Column("minimum_quantum_of_supply_pieces")]
        public int MinimumQuantumOfSupplyPieces { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary> PartnerId </summary>
        [Column("partner_id")]
        public int PartnerId { get; set; }
        
        [ForeignKey(nameof(PartnerId))]
        public virtual Partner Partner { get; set; }
        
        /// <summary> SalesGrowthBudget </summary>
        [Column("sales_growth_budget")]
        public decimal SalesGrowthBudget { get; set; }
        
        /// <summary> Status </summary>
        [Column("status")]
        public int Status { get; set; }
        
        /// <summary> Version </summary>
        [Column("version")]
        public int Version { get; set; }
    }
}

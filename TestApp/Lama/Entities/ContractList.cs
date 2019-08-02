namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> ContractList entity </summary>
    [Table("contract_list", Schema="dbo")]
    public class ContractList
    {
        /// <summary> ContractCode </summary>
        [Column("contract_code")]
        [Key()]
        public string ContractCode { get; set; }
        
        /// <summary> Name </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}

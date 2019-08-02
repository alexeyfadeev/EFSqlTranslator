namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> OfferLine entity </summary>
    [Table("offer_line", Schema="dbo")]
    public class OfferLine
    {
        /// <summary> DeferredPaymentDays </summary>
        [Column("deferred_payment_days")]
        public System.Nullable<int> DeferredPaymentDays { get; set; }
        
        /// <summary> OfferId </summary>
        [Column("offer_id")]
        public int OfferId { get; set; }
        
        /// <summary> PriceDistributionCenter </summary>
        [Column("price_distribution_center")]
        public System.Nullable<decimal> PriceDistributionCenter { get; set; }
        
        /// <summary> PriceExWorks </summary>
        [Column("price_exworks")]
        public System.Nullable<decimal> PriceExWorks { get; set; }
        
        /// <summary> PriceMultipleDistributionCenters </summary>
        [Column("price_multiple_distribution_centers")]
        public System.Nullable<decimal> PriceMultipleDistributionCenters { get; set; }
        
        /// <summary> PriceOutlet </summary>
        [Column("price_outlet")]
        public System.Nullable<decimal> PriceOutlet { get; set; }
        
        /// <summary> PriceTransit </summary>
        [Column("price_transit")]
        public System.Nullable<decimal> PriceTransit { get; set; }
        
        /// <summary> ProductCode </summary>
        [Column("product_code")]
        public string ProductCode { get; set; }
        
        /// <summary> RegionId </summary>
        [Column("region_id")]
        public int RegionId { get; set; }
        
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; }
        
        /// <summary> SalesVolumeInCompetitorStore </summary>
        [Column("sales_volume_in_competitor_store")]
        public System.Nullable<float> SalesVolumeInCompetitorStore { get; set; }
        
        /// <summary> ShareSales </summary>
        [Column("share_sales")]
        public System.Nullable<float> ShareSales { get; set; }
        
        /// <summary> Status </summary>
        [Column("status")]
        public int Status { get; set; }
        
        /// <summary> Version </summary>
        [Column("version")]
        public int Version { get; set; }
        
        /// <summary> Sql Xml </summary>
        public string SqlXml
        {
            get
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb = sb.Append("<Item>\n");
                sb = sb.Append("<DeferredPaymentDays>");
                sb = sb.Append(this.DeferredPaymentDays);
                sb = sb.Append("</DeferredPaymentDays>\n");
                sb = sb.Append("<OfferId>");
                sb = sb.Append(this.OfferId);
                sb = sb.Append("</OfferId>\n");
                sb = sb.Append("<PriceDistributionCenter>");
                sb = sb.Append((this.PriceDistributionCenter.HasValue ? this.PriceDistributionCenter.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</PriceDistributionCenter>\n");
                sb = sb.Append("<PriceExWorks>");
                sb = sb.Append((this.PriceExWorks.HasValue ? this.PriceExWorks.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</PriceExWorks>\n");
                sb = sb.Append("<PriceMultipleDistributionCenters>");
                sb = sb.Append((this.PriceMultipleDistributionCenters.HasValue ? this.PriceMultipleDistributionCenters.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</PriceMultipleDistributionCenters>\n");
                sb = sb.Append("<PriceOutlet>");
                sb = sb.Append((this.PriceOutlet.HasValue ? this.PriceOutlet.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</PriceOutlet>\n");
                sb = sb.Append("<PriceTransit>");
                sb = sb.Append((this.PriceTransit.HasValue ? this.PriceTransit.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</PriceTransit>\n");
                sb = sb.Append("<ProductCode>");
                sb = sb.Append(this.ProductCode);
                sb = sb.Append("</ProductCode>\n");
                sb = sb.Append("<RegionId>");
                sb = sb.Append(this.RegionId);
                sb = sb.Append("</RegionId>\n");
                sb = sb.Append("<SalesVolumeInCompetitorStore>");
                sb = sb.Append((this.SalesVolumeInCompetitorStore.HasValue ? this.SalesVolumeInCompetitorStore.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</SalesVolumeInCompetitorStore>\n");
                sb = sb.Append("<ShareSales>");
                sb = sb.Append((this.ShareSales.HasValue ? this.ShareSales.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</ShareSales>\n");
                sb = sb.Append("<Status>");
                sb = sb.Append(this.Status);
                sb = sb.Append("</Status>\n");
                sb = sb.Append("<Version>");
                sb = sb.Append(this.Version);
                sb = sb.Append("</Version>\n");
                sb = sb.Append("</Item>\n");
                return sb.ToString().Replace("\'", "\'\'");
            }
        }
        
        /// <summary> Common sql </summary>
        public string CommonSql
        {
            get
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb = sb.Append("WITH q1 AS(\nSELECT\n");
                sb = sb.Append("t.value('(DeferredPaymentDays/text())[1]', 'int') AS [deferred_payment_days], ");
                sb = sb.Append("t.value('(OfferId/text())[1]', 'int') AS [offer_id], ");
                sb = sb.Append("t.value('(PriceDistributionCenter/text())[1]', 'decimal') AS [price_distribution_center], ");
                sb = sb.Append("t.value('(PriceExWorks/text())[1]', 'decimal') AS [price_exworks], ");
                sb = sb.Append("t.value('(PriceMultipleDistributionCenters/text())[1]', 'decimal') AS [price_multiple_distribution_centers], ");
                sb = sb.Append("t.value('(PriceOutlet/text())[1]', 'decimal') AS [price_outlet], ");
                sb = sb.Append("t.value('(PriceTransit/text())[1]', 'decimal') AS [price_transit], ");
                sb = sb.Append("t.value('(ProductCode/text())[1]', 'nvarchar(max)') AS [product_code], ");
                sb = sb.Append("t.value('(RegionId/text())[1]', 'int') AS [region_id], ");
                sb = sb.Append("t.value('(SalesVolumeInCompetitorStore/text())[1]', 'real') AS [sales_volume_in_competitor_store], ");
                sb = sb.Append("t.value('(ShareSales/text())[1]', 'real') AS [share_sales], ");
                sb = sb.Append("t.value('(Status/text())[1]', 'int') AS [status], ");
                sb = sb.Append("t.value('(Version/text())[1]', 'int') AS [version]");
                sb = sb.Append("\nFROM @xml.nodes(\'/Item\') AS x(t)\n)\n\n");
                return sb.ToString();
            }
        }
        
        /// <summary> Common insert sql </summary>
        public string CommonInsertSql
        {
            get
            {
                return (this.CommonSql + @"INSERT INTO dbo.offer_line (deferred_payment_days, offer_id, price_distribution_center, price_exworks, price_multiple_distribution_centers, price_outlet, price_transit, product_code, region_id, sales_volume_in_competitor_store, share_sales, status, version) SELECT * FROM q1;");
            }
        }
        
        /// <summary> Common update sql </summary>
        public string CommonUpdateSql
        {
            get
            {
                return (this.CommonSql + @"UPDATE t SET t.deferred_payment_days=q1.deferred_payment_days, t.price_distribution_center=q1.price_distribution_center, t.price_exworks=q1.price_exworks, t.price_multiple_distribution_centers=q1.price_multiple_distribution_centers, t.price_outlet=q1.price_outlet, t.price_transit=q1.price_transit, t.sales_volume_in_competitor_store=q1.sales_volume_in_competitor_store, t.share_sales=q1.share_sales, t.status=q1.status FROM q1 JOIN dbo.offer_line t ON t.offer_id=q1.offer_id AND t.product_code=q1.product_code AND t.region_id=q1.region_id AND t.version=q1.version;");
            }
        }
    }
}

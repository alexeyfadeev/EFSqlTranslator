namespace Lama.ContractorPortal.Sql.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    /// <summary> Product entity </summary>
    [Table("product", Schema="dbo")]
    public class Product
    {
        /// <summary> AwardWithoutVat </summary>
        [Column("award_without_vat")]
        public System.Nullable<decimal> AwardWithoutVat { get; set; }
        
        /// <summary> AwardWithVat </summary>
        [Column("award_with_vat")]
        public System.Nullable<decimal> AwardWithVat { get; set; }
        
        /// <summary> BarCode </summary>
        [Column("barcode")]
        public string BarCode { get; set; }
        
        /// <summary> BarCode2 </summary>
        [Column("barcode2")]
        public string BarCode2 { get; set; }
        
        /// <summary> BarCode3 </summary>
        [Column("barcode3")]
        public string BarCode3 { get; set; }
        
        /// <summary> BarCode4 </summary>
        [Column("barcode4")]
        public string BarCode4 { get; set; }
        
        /// <summary> BarCode5 </summary>
        [Column("barcode5")]
        public string BarCode5 { get; set; }
        
        /// <summary> Brand </summary>
        [Column("brand")]
        public string Brand { get; set; }
        
        /// <summary> CaseGrossWeight </summary>
        [Column("case_gross_weight")]
        public System.Nullable<float> CaseGrossWeight { get; set; }
        
        /// <summary> CaseQuantity </summary>
        [Column("case_quantity")]
        public System.Nullable<int> CaseQuantity { get; set; }
        
        /// <summary> CategoryId </summary>
        [Column("category_id")]
        public System.Nullable<long> CategoryId { get; set; }
        
        [ForeignKey(nameof(CategoryId))]
        public virtual CategoryList CategoryList { get; set; }
        
        /// <summary> Comment </summary>
        [Column("comment")]
        public string Comment { get; set; }
        
        /// <summary> ConsumerCount </summary>
        [Column("consumer_count")]
        public System.Nullable<int> ConsumerCount { get; set; }
        
        /// <summary> ContractCode </summary>
        [Column("contract_code")]
        public string ContractCode { get; set; }
        
        [ForeignKey(nameof(ContractCode))]
        public virtual ContractList ContractList { get; set; }
        
        /// <summary> CountryOfOrigin </summary>
        [Column("country_of_origin")]
        public string CountryOfOrigin { get; set; }
        
        /// <summary> Depth </summary>
        [Column("depth")]
        public System.Nullable<float> Depth { get; set; }
        
        /// <summary> ExciseTax </summary>
        [Column("excise_tax")]
        public System.Nullable<decimal> ExciseTax { get; set; }
        
        /// <summary> FunctionalName </summary>
        [Column("functional_name")]
        public string FunctionalName { get; set; }
        
        /// <summary> Height </summary>
        [Column("height")]
        public System.Nullable<float> Height { get; set; }
        
        /// <summary> LifespanDays </summary>
        [Column("lifespan_days")]
        public System.Nullable<int> LifespanDays { get; set; }
        
        /// <summary> MasterProductCode </summary>
        [Column("master_product_code")]
        public string MasterProductCode { get; set; }
        
        /// <summary> MinimumOrderPieces </summary>
        [Column("minimum_order_pieces")]
        public System.Nullable<int> MinimumOrderPieces { get; set; }
        
        /// <summary> MinimumOrderSum </summary>
        [Column("minimum_order_sum")]
        public System.Nullable<decimal> MinimumOrderSum { get; set; }
        
        /// <summary> MinimumOrderWeight </summary>
        [Column("minimum_order_weight")]
        public System.Nullable<float> MinimumOrderWeight { get; set; }
        
        /// <summary> MinimumQuantumOfSupplyPieces </summary>
        [Column("minimum_quantum_of_supply_pieces")]
        public System.Nullable<int> MinimumQuantumOfSupplyPieces { get; set; }
        
        /// <summary> NetVolume </summary>
        [Column("net_volume")]
        public System.Nullable<float> NetVolume { get; set; }
        
        /// <summary> NetWeight </summary>
        [Column("net_weight")]
        public System.Nullable<float> NetWeight { get; set; }
        
        /// <summary> OwnershipTypeId </summary>
        [Column("ownership_type_id")]
        public int OwnershipTypeId { get; set; }
        
        /// <summary> PackagingMaterial </summary>
        [Column("packaging_material")]
        public string PackagingMaterial { get; set; }
        
        /// <summary> PalletQuantityCases </summary>
        [Column("pallet_quantity_cases")]
        public System.Nullable<int> PalletQuantityCases { get; set; }
        
        /// <summary> PartnerId </summary>
        [Column("partner_id")]
        public int PartnerId { get; set; }
        
        [ForeignKey(nameof(PartnerId))]
        public virtual Partner Partner { get; set; }
        
        /// <summary> ProductCode </summary>
        [Column("product_code")]
        public string ProductCode { get; set; }
        
        /// <summary> ProductName </summary>
        [Column("product_name")]
        public string ProductName { get; set; }
        
        /// <summary> Standard </summary>
        [Column("standard")]
        public string Standard { get; set; }
        
        /// <summary> Status </summary>
        [Column("status")]
        public int Status { get; set; }
        
        /// <summary> StorageRequirements </summary>
        [Column("storage_requirements")]
        public string StorageRequirements { get; set; }
        
        /// <summary> SubBrand </summary>
        [Column("subbrand")]
        public string SubBrand { get; set; }
        
        /// <summary> Variant </summary>
        [Column("variant")]
        public string Variant { get; set; }
        
        /// <summary> VatRate </summary>
        [Column("vat_rate")]
        public System.Nullable<decimal> VatRate { get; set; }
        
        /// <summary> Version </summary>
        [Column("version")]
        public int Version { get; set; }
        
        /// <summary> WeightProduct </summary>
        [Column("weight_product")]
        public bool WeightProduct { get; set; }
        
        /// <summary> Width </summary>
        [Column("width")]
        public System.Nullable<float> Width { get; set; }
        
        /// <summary> Sql Xml </summary>
        public string SqlXml
        {
            get
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb = sb.Append("<Item>\n");
                sb = sb.Append("<AwardWithoutVat>");
                sb = sb.Append((this.AwardWithoutVat.HasValue ? this.AwardWithoutVat.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</AwardWithoutVat>\n");
                sb = sb.Append("<AwardWithVat>");
                sb = sb.Append((this.AwardWithVat.HasValue ? this.AwardWithVat.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</AwardWithVat>\n");
                sb = sb.Append("<BarCode>");
                sb = sb.Append(this.BarCode);
                sb = sb.Append("</BarCode>\n");
                sb = sb.Append("<BarCode2>");
                sb = sb.Append(this.BarCode2);
                sb = sb.Append("</BarCode2>\n");
                sb = sb.Append("<BarCode3>");
                sb = sb.Append(this.BarCode3);
                sb = sb.Append("</BarCode3>\n");
                sb = sb.Append("<BarCode4>");
                sb = sb.Append(this.BarCode4);
                sb = sb.Append("</BarCode4>\n");
                sb = sb.Append("<BarCode5>");
                sb = sb.Append(this.BarCode5);
                sb = sb.Append("</BarCode5>\n");
                sb = sb.Append("<Brand>");
                sb = sb.Append(this.Brand);
                sb = sb.Append("</Brand>\n");
                sb = sb.Append("<CaseGrossWeight>");
                sb = sb.Append((this.CaseGrossWeight.HasValue ? this.CaseGrossWeight.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</CaseGrossWeight>\n");
                sb = sb.Append("<CaseQuantity>");
                sb = sb.Append(this.CaseQuantity);
                sb = sb.Append("</CaseQuantity>\n");
                sb = sb.Append("<CategoryId>");
                sb = sb.Append(this.CategoryId);
                sb = sb.Append("</CategoryId>\n");
                sb = sb.Append("<Comment>");
                sb = sb.Append(this.Comment);
                sb = sb.Append("</Comment>\n");
                sb = sb.Append("<ConsumerCount>");
                sb = sb.Append(this.ConsumerCount);
                sb = sb.Append("</ConsumerCount>\n");
                sb = sb.Append("<ContractCode>");
                sb = sb.Append(this.ContractCode);
                sb = sb.Append("</ContractCode>\n");
                sb = sb.Append("<CountryOfOrigin>");
                sb = sb.Append(this.CountryOfOrigin);
                sb = sb.Append("</CountryOfOrigin>\n");
                sb = sb.Append("<Depth>");
                sb = sb.Append((this.Depth.HasValue ? this.Depth.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</Depth>\n");
                sb = sb.Append("<ExciseTax>");
                sb = sb.Append((this.ExciseTax.HasValue ? this.ExciseTax.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</ExciseTax>\n");
                sb = sb.Append("<FunctionalName>");
                sb = sb.Append(this.FunctionalName);
                sb = sb.Append("</FunctionalName>\n");
                sb = sb.Append("<Height>");
                sb = sb.Append((this.Height.HasValue ? this.Height.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</Height>\n");
                sb = sb.Append("<LifespanDays>");
                sb = sb.Append(this.LifespanDays);
                sb = sb.Append("</LifespanDays>\n");
                sb = sb.Append("<MasterProductCode>");
                sb = sb.Append(this.MasterProductCode);
                sb = sb.Append("</MasterProductCode>\n");
                sb = sb.Append("<MinimumOrderPieces>");
                sb = sb.Append(this.MinimumOrderPieces);
                sb = sb.Append("</MinimumOrderPieces>\n");
                sb = sb.Append("<MinimumOrderSum>");
                sb = sb.Append((this.MinimumOrderSum.HasValue ? this.MinimumOrderSum.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</MinimumOrderSum>\n");
                sb = sb.Append("<MinimumOrderWeight>");
                sb = sb.Append((this.MinimumOrderWeight.HasValue ? this.MinimumOrderWeight.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</MinimumOrderWeight>\n");
                sb = sb.Append("<MinimumQuantumOfSupplyPieces>");
                sb = sb.Append(this.MinimumQuantumOfSupplyPieces);
                sb = sb.Append("</MinimumQuantumOfSupplyPieces>\n");
                sb = sb.Append("<NetVolume>");
                sb = sb.Append((this.NetVolume.HasValue ? this.NetVolume.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</NetVolume>\n");
                sb = sb.Append("<NetWeight>");
                sb = sb.Append((this.NetWeight.HasValue ? this.NetWeight.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</NetWeight>\n");
                sb = sb.Append("<OwnershipTypeId>");
                sb = sb.Append(this.OwnershipTypeId);
                sb = sb.Append("</OwnershipTypeId>\n");
                sb = sb.Append("<PackagingMaterial>");
                sb = sb.Append(this.PackagingMaterial);
                sb = sb.Append("</PackagingMaterial>\n");
                sb = sb.Append("<PalletQuantityCases>");
                sb = sb.Append(this.PalletQuantityCases);
                sb = sb.Append("</PalletQuantityCases>\n");
                sb = sb.Append("<PartnerId>");
                sb = sb.Append(this.PartnerId);
                sb = sb.Append("</PartnerId>\n");
                sb = sb.Append("<ProductCode>");
                sb = sb.Append(this.ProductCode);
                sb = sb.Append("</ProductCode>\n");
                sb = sb.Append("<ProductName>");
                sb = sb.Append(this.ProductName);
                sb = sb.Append("</ProductName>\n");
                sb = sb.Append("<Standard>");
                sb = sb.Append(this.Standard);
                sb = sb.Append("</Standard>\n");
                sb = sb.Append("<Status>");
                sb = sb.Append(this.Status);
                sb = sb.Append("</Status>\n");
                sb = sb.Append("<StorageRequirements>");
                sb = sb.Append(this.StorageRequirements);
                sb = sb.Append("</StorageRequirements>\n");
                sb = sb.Append("<SubBrand>");
                sb = sb.Append(this.SubBrand);
                sb = sb.Append("</SubBrand>\n");
                sb = sb.Append("<Variant>");
                sb = sb.Append(this.Variant);
                sb = sb.Append("</Variant>\n");
                sb = sb.Append("<VatRate>");
                sb = sb.Append((this.VatRate.HasValue ? this.VatRate.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</VatRate>\n");
                sb = sb.Append("<Version>");
                sb = sb.Append(this.Version);
                sb = sb.Append("</Version>\n");
                sb = sb.Append("<WeightProduct>");
                sb = sb.Append(this.WeightProduct);
                sb = sb.Append("</WeightProduct>\n");
                sb = sb.Append("<Width>");
                sb = sb.Append((this.Width.HasValue ? this.Width.Value.ToString() : "").Replace(',', '.'));
                sb = sb.Append("</Width>\n");
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
                sb = sb.Append("t.value('(AwardWithoutVat/text())[1]', 'decimal') AS [award_without_vat], ");
                sb = sb.Append("t.value('(AwardWithVat/text())[1]', 'decimal') AS [award_with_vat], ");
                sb = sb.Append("t.value('(BarCode/text())[1]', 'nvarchar(max)') AS [barcode], ");
                sb = sb.Append("t.value('(BarCode2/text())[1]', 'nvarchar(max)') AS [barcode2], ");
                sb = sb.Append("t.value('(BarCode3/text())[1]', 'nvarchar(max)') AS [barcode3], ");
                sb = sb.Append("t.value('(BarCode4/text())[1]', 'nvarchar(max)') AS [barcode4], ");
                sb = sb.Append("t.value('(BarCode5/text())[1]', 'nvarchar(max)') AS [barcode5], ");
                sb = sb.Append("t.value('(Brand/text())[1]', 'nvarchar(max)') AS [brand], ");
                sb = sb.Append("t.value('(CaseGrossWeight/text())[1]', 'real') AS [case_gross_weight], ");
                sb = sb.Append("t.value('(CaseQuantity/text())[1]', 'int') AS [case_quantity], ");
                sb = sb.Append("t.value('(CategoryId/text())[1]', 'bigint') AS [category_id], ");
                sb = sb.Append("t.value('(Comment/text())[1]', 'nvarchar(max)') AS [comment], ");
                sb = sb.Append("t.value('(ConsumerCount/text())[1]', 'int') AS [consumer_count], ");
                sb = sb.Append("t.value('(ContractCode/text())[1]', 'nvarchar(max)') AS [contract_code], ");
                sb = sb.Append("t.value('(CountryOfOrigin/text())[1]', 'nvarchar(max)') AS [country_of_origin], ");
                sb = sb.Append("t.value('(Depth/text())[1]', 'real') AS [depth], ");
                sb = sb.Append("t.value('(ExciseTax/text())[1]', 'decimal') AS [excise_tax], ");
                sb = sb.Append("t.value('(FunctionalName/text())[1]', 'nvarchar(max)') AS [functional_name], ");
                sb = sb.Append("t.value('(Height/text())[1]', 'real') AS [height], ");
                sb = sb.Append("t.value('(LifespanDays/text())[1]', 'int') AS [lifespan_days], ");
                sb = sb.Append("t.value('(MasterProductCode/text())[1]', 'nvarchar(max)') AS [master_product_code], ");
                sb = sb.Append("t.value('(MinimumOrderPieces/text())[1]', 'int') AS [minimum_order_pieces], ");
                sb = sb.Append("t.value('(MinimumOrderSum/text())[1]', 'decimal') AS [minimum_order_sum], ");
                sb = sb.Append("t.value('(MinimumOrderWeight/text())[1]', 'real') AS [minimum_order_weight], ");
                sb = sb.Append("t.value('(MinimumQuantumOfSupplyPieces/text())[1]', 'int') AS [minimum_quantum_of_supply_pieces], ");
                sb = sb.Append("t.value('(NetVolume/text())[1]', 'real') AS [net_volume], ");
                sb = sb.Append("t.value('(NetWeight/text())[1]', 'real') AS [net_weight], ");
                sb = sb.Append("t.value('(OwnershipTypeId/text())[1]', 'int') AS [ownership_type_id], ");
                sb = sb.Append("t.value('(PackagingMaterial/text())[1]', 'nvarchar(max)') AS [packaging_material], ");
                sb = sb.Append("t.value('(PalletQuantityCases/text())[1]', 'int') AS [pallet_quantity_cases], ");
                sb = sb.Append("t.value('(PartnerId/text())[1]', 'int') AS [partner_id], ");
                sb = sb.Append("t.value('(ProductCode/text())[1]', 'nvarchar(max)') AS [product_code], ");
                sb = sb.Append("t.value('(ProductName/text())[1]', 'nvarchar(max)') AS [product_name], ");
                sb = sb.Append("t.value('(Standard/text())[1]', 'nvarchar(max)') AS [standard], ");
                sb = sb.Append("t.value('(Status/text())[1]', 'int') AS [status], ");
                sb = sb.Append("t.value('(StorageRequirements/text())[1]', 'nvarchar(max)') AS [storage_requirements], ");
                sb = sb.Append("t.value('(SubBrand/text())[1]', 'nvarchar(max)') AS [subbrand], ");
                sb = sb.Append("t.value('(Variant/text())[1]', 'nvarchar(max)') AS [variant], ");
                sb = sb.Append("t.value('(VatRate/text())[1]', 'decimal') AS [vat_rate], ");
                sb = sb.Append("t.value('(Version/text())[1]', 'int') AS [version], ");
                sb = sb.Append("t.value('(WeightProduct/text())[1]', 'bit') AS [weight_product], ");
                sb = sb.Append("t.value('(Width/text())[1]', 'real') AS [width]");
                sb = sb.Append("\nFROM @xml.nodes(\'/Item\') AS x(t)\n)\n\n");
                return sb.ToString();
            }
        }
        
        /// <summary> Common insert sql </summary>
        public string CommonInsertSql
        {
            get
            {
                return (this.CommonSql + @"INSERT INTO dbo.product (award_without_vat, award_with_vat, barcode, barcode2, barcode3, barcode4, barcode5, brand, case_gross_weight, case_quantity, category_id, comment, consumer_count, contract_code, country_of_origin, depth, excise_tax, functional_name, height, lifespan_days, master_product_code, minimum_order_pieces, minimum_order_sum, minimum_order_weight, minimum_quantum_of_supply_pieces, net_volume, net_weight, ownership_type_id, packaging_material, pallet_quantity_cases, partner_id, product_code, product_name, standard, status, storage_requirements, subbrand, variant, vat_rate, version, weight_product, width) SELECT * FROM q1;");
            }
        }
        
        /// <summary> Common update sql </summary>
        public string CommonUpdateSql
        {
            get
            {
                return (this.CommonSql + @"UPDATE t SET t.award_without_vat=q1.award_without_vat, t.award_with_vat=q1.award_with_vat, t.barcode=q1.barcode, t.barcode2=q1.barcode2, t.barcode3=q1.barcode3, t.barcode4=q1.barcode4, t.barcode5=q1.barcode5, t.brand=q1.brand, t.case_gross_weight=q1.case_gross_weight, t.case_quantity=q1.case_quantity, t.category_id=q1.category_id, t.comment=q1.comment, t.consumer_count=q1.consumer_count, t.contract_code=q1.contract_code, t.country_of_origin=q1.country_of_origin, t.depth=q1.depth, t.excise_tax=q1.excise_tax, t.functional_name=q1.functional_name, t.height=q1.height, t.lifespan_days=q1.lifespan_days, t.master_product_code=q1.master_product_code, t.minimum_order_pieces=q1.minimum_order_pieces, t.minimum_order_sum=q1.minimum_order_sum, t.minimum_order_weight=q1.minimum_order_weight, t.minimum_quantum_of_supply_pieces=q1.minimum_quantum_of_supply_pieces, t.net_volume=q1.net_volume, t.net_weight=q1.net_weight, t.ownership_type_id=q1.ownership_type_id, t.packaging_material=q1.packaging_material, t.pallet_quantity_cases=q1.pallet_quantity_cases, t.product_name=q1.product_name, t.standard=q1.standard, t.status=q1.status, t.storage_requirements=q1.storage_requirements, t.subbrand=q1.subbrand, t.variant=q1.variant, t.vat_rate=q1.vat_rate, t.weight_product=q1.weight_product, t.width=q1.width FROM q1 JOIN dbo.product t ON t.partner_id=q1.partner_id AND t.product_code=q1.product_code AND t.version=q1.version;");
            }
        }
    }
}

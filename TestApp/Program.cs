using System;

namespace TestApp
{
    using System.Linq;
    
    using Dapper;
    using EFSqlTranslator.EFModels;
    using EFSqlTranslator.Translation;
    using EFSqlTranslator.Translation.DbObjects.PostgresQlObjects;
    using EFSqlTranslator.Translation.DbObjects.SqlObjects;
    using EFSqlTranslator.Translation.Extensions;
    using Fadeev.PostgresEfTest.Ef;
    using Lama.ContractorPortal.Sql;
    using RedAlliance.Orm.Sql;

    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.TestLama();
        }

        private KtkDbContext GetKtkContext()
        {
            var connStr = "Server=localhost;Port=5432;User Id=atis;Password=fnbc;Database=ktk";

            return new KtkDbContext(connStr);
        }

        private LamaDbContext GetLamaContext()
        {
            var connStr = "Data Source=vm-lama.development.com; Initial Catalog=Lama; Integrated Security=False; User Id=lama; Password=kfvfadmin; MultipleActiveResultSets=True";

            return new LamaDbContext(connStr);
        }

        private TestDbContext GetTestContext()
        {
            var connStr = "Server=localhost;Port=5432;User Id=alexeys;Password=1;Database=test";

            return new TestDbContext(connStr);
        }

        private void TestCount()
        {
            using (var context = this.GetKtkContext())
            {
                var query = context.DefectTypes
                    .GroupBy(x => x.DefectCategoryId)
                    .Select(g => new {g.Key, Cnt = g.DistinctCount(x => x.DefectCategoryId)});
                    //Select(x => x.DefectCategoryId).Distinct();
                    //.OrderBy(x => x.DefectCategoryId);

                var result = context.Query(query, new EFModelInfoProvider(context), new PostgresQlObjectFactory(), out var sql)
                    .ToList();

                var offline = context.DefectTypes.ToList();

                var result2 = offline.GroupBy(x => x.DefectCategoryId)
                    .Select(g => new { g.Key, Cnt = g.DistinctCount(x => x.DefectCategoryId) })
                    .ToList();
            }
        }

        private void TestLama()
        {
            using (var context = this.GetLamaContext())
            {
                /*
                var query = context.Products
                    .GroupBy(x => x.ProductCode)
                    .Select(g => new { g.Key, Cnt = g.DistinctCount(x => x.PartnerId) });

                var result = context.Query(query, new EFModelInfoProvider(context), new SqlObjectFactory(), out var sql)
                    .ToList();

                var offline = context.Products.ToList();

                var result2 = offline.GroupBy(x => x.ProductCode)
                    .Select(g => new { g.Key, Cnt = g.DistinctCount(x => x.PartnerId) })
                    .ToList();
                    */
                
                var query4 = context.Partners
                    .Where(x => x.Site != null)
                    .Select(x => new { agg = x.Contacts.DistinctCount(c => c.Role) });
                // OK

                var result4 = context.Query(query4, new EFModelInfoProvider(context), new SqlObjectFactory(), out var sql)
                    .ToList();

                var query3 = context.Partners
                    .Select(x => new { x.Name, agg = x.Contacts.DistinctCount(c => c.Role) });
                // 1. Max/Sum - OK, DistinctCount - crash

                // var script0 = QueryTranslator.Translate(query3.Expression, new EFModelInfoProvider(context), new SqlObjectFactory());
                // var sql4 = script0.ToString();

                var script = context.Query(query3, new EFModelInfoProvider(context), new SqlObjectFactory());
                var result3 = script.ToList();

                var query5 = context.Partners
                    .Select(x => x.Contacts.Max(c => c.Role));

                var script5 = QueryTranslator.Translate(query3.Expression, new EFModelInfoProvider(context), new SqlObjectFactory());
                var sql5 = script5.ToString();
                // OK
                var result5 = context.Query(query5, new EFModelInfoProvider(context), new SqlObjectFactory()).ToList();
                // crash(!)
            }
        }

        private void TestArray()
        {
            using (var context = this.GetTestContext())
            {

            }
        }
    }
}

using System;

namespace TestApp
{
    using System.Linq;
    
    using Dapper;
    using EFSqlTranslator.EFModels;
    using EFSqlTranslator.Translation.DbObjects.PostgresQlObjects;
    using EFSqlTranslator.Translation.Extensions;
    using Fadeev.PostgresEfTest.Ef;
    using Lama.ContractorPortal.Sql;

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
                var query = context.Products
                    .GroupBy(x => x.ProductCode)
                    .Select(g => new { g.Key, Cnt = g.DistinctCount(x => x.PartnerId) });

                var result = context.Query(query, new EFModelInfoProvider(context), new PostgresQlObjectFactory(), out var sql)
                    .ToList();

                var offline = context.Products.ToList();

                var result2 = offline.GroupBy(x => x.ProductCode)
                    .Select(g => new { g.Key, Cnt = g.DistinctCount(x => x.PartnerId) })
                    .ToList();
            }
        }
    }
}

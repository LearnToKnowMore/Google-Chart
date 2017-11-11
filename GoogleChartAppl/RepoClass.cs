using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Data;
namespace GoogleChartAppl
{
    public class RepoClass
    {
        public IEnumerable<Category_Sales_for_1997> GetData()
        {
            using (var ctx = new NorthwindEntities())
            {
                List<Category_Sales_for_1997> saledata = ctx.Category_Sales_for_1997.ToList();
                return saledata;
            }
        }
        public IEnumerable<CountOfSuppliersByCountry_Result> GetSupplierData()
        {
            using (var ctx = new NorthwindEntities())
            {
                var query = ctx.CountOfSuppliersByCountry();
                return query.ToList();
            }
        }

        public ICollection<U_CategoryWiseSales_1996_1997_Result> GetCategoryWiseSales_1996_1997()
        {
            using (var ctx = new NorthwindEntities())
            {
                var query = ctx.U_CategoryWiseSales_1996_1997();
                return query.ToList();
            }
        }

        public IList<U_CategoryWiseTotalSales_1996_1997_Result> GetU_CategoryWiseTotalSales_1996_1997()
        {
            using (var ctx = new NorthwindEntities())
            {
                var result = ctx.U_CategoryWiseTotalSales_1996_1997();
                return result.ToArray();
            }
        }
    }
}
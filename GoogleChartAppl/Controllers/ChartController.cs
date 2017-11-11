using System.Web.Mvc;
using System.Web.Services;

namespace GoogleChartAppl.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        RepoClass getDataFromEntities = new RepoClass();
        public JsonResult GetData()
        {
            var ChartData = getDataFromEntities.GetData();
            return Json(ChartData, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult GetSupplierData()
        {
            var MapData = getDataFromEntities.GetSupplierData();
            return Json(MapData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCategoryWiseSales_1996_1997()
        {
            var DiffData = getDataFromEntities.GetCategoryWiseSales_1996_1997();
            return Json(DiffData, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetU_CategoryWiseTotalSales_1996_1997()
        {
            var ComboData = getDataFromEntities.GetU_CategoryWiseTotalSales_1996_1997();
            return Json(ComboData, JsonRequestBehavior.AllowGet);
        }
    }
}
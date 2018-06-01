using ServiceResponse;
using System.Web.Mvc;
using WebApplication12.Task;
namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public dynamic Test()
        {
            var personTask = new PersonTask().getAllPersonWithHelper();
            if (personTask.Status == ServiceResultStatus.Fail) return "";
            var result= personTask.Data;
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}
using SampleApplication.Task;
using ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SampleApplication.Controllers
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
        public JsonResult TestForSuccessStructure()
        {
            var personTask = new PersonTask().getAllPersonWithHelper();
            if (personTask.Status == ServiceResultStatus.Fail) return Json(personTask.Message, JsonRequestBehavior.AllowGet);
            var result = personTask.Data;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult TestForFailStructure()
        {
            var personTask = new PersonTask().findPersonWithId(5);
            if (personTask.Status == ServiceResultStatus.Fail) return Json(personTask.Message, JsonRequestBehavior.AllowGet);
            var result = personTask.Data;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
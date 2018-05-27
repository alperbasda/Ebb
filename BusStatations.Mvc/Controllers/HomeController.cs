using System;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BusStatations.Mvc.Models;
using BusStatations.Mvc.UpdateMonitorService;

namespace BusStatations.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UpdateMonitorService.UpdateMonitorClient update = new UpdateMonitorClient();
            update.InnerChannel.OperationTimeout = new TimeSpan(0, 10, 0);
            string s = update.Update(12);
            JavaScriptSerializer deSerializer = new JavaScriptSerializer();
            JsonData a = deSerializer.Deserialize<JsonData>(s);
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
    }
}
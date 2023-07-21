using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechXccelerate.Controllers
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

        public ActionResult Homepg()
        {
            ViewBag.Message = "Your Homepg page.";

            return View();
        }


        //calendar stuff
        //private String displaDays()
        //{
        //    DateTime now = DateTime.Now;

        //    //first day of month
        //    DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

        //    //count of days in the month
        //    int days = DateTime.DaysInMonth(now.Year, now.Month);

        //    int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1;
            
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechXccelerate.Models;

namespace TechXccelerate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View(1);
        //}

        public ActionResult About(int num)
        {
            //Dates obj = new Dates();
            //obj.WeekDay = "Saturday";
            //obj.Month = "July";
            //obj.Number = 1;
            //obj.Year = 2023;
            //var obj = Convert.ToDateTime(date);

            return View(num);
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
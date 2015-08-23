using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingComboBox1.Models;

namespace CascadingComboBox1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CountryList()
        {
            IQueryable countries = Country.GetCountries();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                            countries,
                            "CountryCode",
                            "CountryName"), JsonRequestBehavior.AllowGet
                            );
            }

            return View(countries);
        }

        public ActionResult StateList(string CountryCode)
        {
            IQueryable states = State.GetStates().Where(x => x.CountryCode == CountryCode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                                states,
                                "StateID",
                                "StateName"), JsonRequestBehavior.AllowGet
                            );

            return View(states);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

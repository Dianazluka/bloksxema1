using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Web.Mvc;
using CalcStackDoDies.TwoArgument;

namespace WebinterfaceCalc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Plus", Value = "Plus"},
                new SelectListItem {Text = "Minus", Value = "Minus"},
                new SelectListItem {Text = "Mul", Value = "Mul"},
                new SelectListItem {Text = "Div", Value = "Div"}
            };
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

        public ActionResult Calculate(double first, double second, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(first, second);
            return View(result);
        }
    }
}
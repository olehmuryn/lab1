using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //hhhgg
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string firstNumber, string secondNumber, string Cal)
        {
            double a;
            double b;
            if (secondNumber != "" && firstNumber != "" && double.TryParse(secondNumber, out b) && double.TryParse(firstNumber, out a))
            {
                
                double c = 0;
                switch (Cal)
                {
                    case "Add":
                        c = a + b;
                        break;
                    case "Sub":
                        c = a - b;
                        break;
                    case "Mul":
                        c = a * b;
                        break;
                    case "Div":
                        c = a / b;
                        break;
                }
                ViewBag.Result = c;
                return View();
            }
            else
            {
                return View();
            }
             
            
            
        }  

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6Assessment.Controllers
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
        public ActionResult Result()
        {

            return View();

        }

        public ActionResult AddNumbers(int Num1, int Num2)
        {
            int[] numbers = new int[2];
            numbers[0] = Num1;
            numbers[1] = Num2;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                ViewBag.Result = sum;
            }
            ViewBag.message = ("The Result is " + sum);
            return View("Result");


        }
    }
}
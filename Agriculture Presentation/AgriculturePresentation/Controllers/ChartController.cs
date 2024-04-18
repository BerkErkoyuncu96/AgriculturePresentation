using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult productChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();

            productClasses.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 800
            });

            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 1000
            });

            productClasses.Add(new ProductClass
            {
                productname = "Yulaf",
                productvalue = 1500
            });
            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 950
            });
            productClasses.Add(new ProductClass
            {
                productname = "Çavdar",
                productvalue = 750
            });

            return Json(new { jsonList = productClasses });
        }

    }
}

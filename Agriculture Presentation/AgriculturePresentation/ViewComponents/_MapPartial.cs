using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _MapPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            AgricultureContext context = new AgricultureContext();
            var value = context.Adresses.Select(x=>x.Map).FirstOrDefault();
            ViewBag.Map = value;
            return View();
        }
    }
}

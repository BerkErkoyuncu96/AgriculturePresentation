using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        public readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var value = _contactService.GetListAll();
            return View(value);
        }

        public IActionResult deleteMessage(int id) 
        {
            var value = _contactService.GetById(id);
            _contactService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult messageDetails(int id) 
        {
            var value = _contactService.GetById(id);
            return View(value);
        }
    }
}

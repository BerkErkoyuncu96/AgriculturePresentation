using BuisnessLayer.Abstract;
using BuisnessLayer.Validation_Rules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AdressController : Controller
    {
        public readonly IAdressService _adressService;

        public AdressController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult Index()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult updateAdress(int id)
        {
            var value = _adressService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult updateAdress(Adress adress)
        {
            AdressValidator validationRules = new AdressValidator();
            ValidationResult result = validationRules.Validate(adress);
            if (result.IsValid)
            {
                _adressService.Update(adress);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
      
    }
}

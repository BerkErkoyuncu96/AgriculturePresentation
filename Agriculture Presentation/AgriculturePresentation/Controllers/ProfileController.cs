using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Mail = values.Email;
            userEditViewModel.phoneNumber = values.PhoneNumber;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEditViewModel.password == userEditViewModel.passwordConfirm)
            {
                values.Email = userEditViewModel.Mail;
                values.PhoneNumber = userEditViewModel.phoneNumber;
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, userEditViewModel.password);
                var result = await _userManager.UpdateAsync(values);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }
            }
            return View();
        }
    }
}

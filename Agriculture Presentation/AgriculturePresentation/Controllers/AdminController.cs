using BuisnessLayer.Abstract;
using BuisnessLayer.Validation_Rules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
	public class AdminController : Controller
	{
		private readonly IAdminService _adminService;

		public AdminController(IAdminService adminService)
		{
			_adminService = adminService;
		}

		public IActionResult Index()
		{
			var values = _adminService.GetListAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult addAdmin()
		{
			return View();
		}
		[HttpPost]
		public IActionResult addAdmin(Admin admin)
		{
			_adminService.Insert(admin);
			return RedirectToAction("Index");
		}

		public IActionResult deleteAdmin(int id)
		{
			var value = _adminService.GetById(id);
			_adminService.Delete(value);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult updateAdmin(int id)
		{
			var value = _adminService.GetById(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult updateAdmin(Admin admin)
		{

				_adminService.Update(admin);
				return RedirectToAction("Index");

		}
	}
}

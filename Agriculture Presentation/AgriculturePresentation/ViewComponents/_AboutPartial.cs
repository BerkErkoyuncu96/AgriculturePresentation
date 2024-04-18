using BuisnessLayer.Abstract;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _AboutPartial :ViewComponent
	{
		private readonly IAboutService _aboutService;

		public _AboutPartial(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}
		public IViewComponentResult Invoke()
		{
			AgricultureContext context = new AgricultureContext();
			var value = context.Abouts.ToList();
			return View(value);
		}
	}
}

using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _GalleryPartial : ViewComponent
	{
		private readonly IImageService _ımageService;

		public _GalleryPartial(IImageService ımageService)
		{
			_ımageService = ımageService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _ımageService.GetListAll();
			return View(value);
		}
	}
}

using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _SocialMediaPartial : ViewComponent
	{
		public readonly ISocialMediaService _socialMediaService;

		public _SocialMediaPartial(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke() {
			var value = _socialMediaService.GetListAll();		
			return View(value);
		}
	}
}

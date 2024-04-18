using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _TeamPartial : ViewComponent
	{
		public readonly ITeamService _teamService;

		public _TeamPartial(ITeamService teamService)
		{
			this._teamService = teamService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _teamService.GetListAll();
			return View(value);
		}
	}
}

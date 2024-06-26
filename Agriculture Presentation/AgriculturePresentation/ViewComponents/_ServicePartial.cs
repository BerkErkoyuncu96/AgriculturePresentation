﻿using BuisnessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _ServicePartial : ViewComponent
	{
		private readonly IServiceService _serviceService;

		public _ServicePartial(IServiceService serviceService)
		{
			this._serviceService = serviceService;
		}
		public IViewComponentResult Invoke()
		{
			var value = _serviceService.GetListAll();
			return View(value);
		}
	}
}

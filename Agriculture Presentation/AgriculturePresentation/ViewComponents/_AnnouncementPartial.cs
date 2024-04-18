using BuisnessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _AnnouncementPartial : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public _AnnouncementPartial(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IViewComponentResult Invoke()
        {
            Announcement announcement = new Announcement();
            if (announcement.Status == true)
            {
                var values = _announcementService.GetListAll();
                return View(values);
            }
            else
            {
                return View(null);
            }
        }
    }
}

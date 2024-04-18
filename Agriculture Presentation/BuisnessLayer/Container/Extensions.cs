using BuisnessLayer.Abstract;
using BuisnessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection Services)
        {
            Services.AddScoped<IServiceService, ServiceManager>();
            Services.AddScoped<IServiceDal, EntityFrameworkServiceDal>();
            Services.AddScoped<ITeamService, TeamManager>();
            Services.AddScoped<ITeamDal, EntityFrameworkTeamDal>();
            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EntityFrameworkAnnouncementDal>();
            Services.AddScoped<IImageService, ImageManager>();
            Services.AddScoped<IImageDal, EntityFrameworkImageDal>();
            Services.AddScoped<IAdressService, AdressManager>();
            Services.AddScoped<IAdressDal, EntityFrameworkAdressDal>();
            Services.AddScoped<IContactService, ContactManager>();
            Services.AddScoped<IContactDal, EntityFrameworkContactDal>();
            Services.AddScoped<ISocialMediaService, SocialMediaManager>();
            Services.AddScoped<ISocialMediaDal, EntityFrameworkSocialMediaDal>();
            Services.AddScoped<IAboutService, AboutManager>();
            Services.AddScoped<IAboutDal, EntityFrameworkAboutDal>();
            Services.AddScoped<IAdminService, AdminManager>();
            Services.AddScoped<IAdminDal, EntityFrameworkAdminDal>();
        } 
    }
}

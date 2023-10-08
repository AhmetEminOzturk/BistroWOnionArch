using BistroWOnionArch.Core.Application.Services.AboutServices;
using BistroWOnionArch.Core.Application.Services.CategoryServices;
using BistroWOnionArch.Core.Application.Services.DishServices;
using BistroWOnionArch.Core.Application.Services.OurDishServices;
using BistroWOnionArch.Core.Application.Services.OurServiceServices;
using BistroWOnionArch.Core.Application.Services.OurSpecialServices;
using BistroWOnionArch.Core.Application.Services.StatisticServices;
using BistroWOnionArch.Core.Application.Services.WelcomeBannerServices;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.AboutRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.CategoryRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.DishRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurDishRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurServiceRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.OurSpecialRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.StatisticRepository;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.WelcomeBannerRepository;
using Microsoft.EntityFrameworkCore;

namespace BistroWOnionArch.Presentation.WebUI.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutRepository, EFAboutRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();

            services.AddScoped<IDishService, DishService>();
            services.AddScoped<IDishRepository, EFDishRepository>();

            services.AddScoped<IOurDishService, OurDishService>();
            services.AddScoped<IOurDishRepository, EFOurDishRepository>();

            services.AddScoped<IOurServiceService, OurServiceService>();
            services.AddScoped<IOurServiceRepository, EFOurServiceRepository>();

            services.AddScoped<IOurSpecialService, OurSpecialService>();
            services.AddScoped<IOurSpecialRepository, EFOurSpecialRepository>();

            services.AddScoped<IStatisticService, StatisticService>();
            services.AddScoped<IStatisticRepository, EFStatisticRepository>();

            services.AddScoped<IWelcomeBannerService, WelcomeBannerService>();
            services.AddScoped<IWelcomeBannerRepository, EFWelcomeBannerRepository>();
            //IoC
            services.AddDbContext<BistroWOnionArchDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}

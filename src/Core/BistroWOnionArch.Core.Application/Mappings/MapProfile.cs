using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.About.Responses;
using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<DisplayAboutResponse,About>().ReverseMap();
            CreateMap<DisplayCategoryResponse,Category>().ReverseMap();
            CreateMap<DisplayDishResponse,Dish>().ReverseMap();
            CreateMap<DisplayOurDishResponse,OurDish>().ReverseMap();
            CreateMap<DisplayOurServiceResponse,OurService>().ReverseMap();
            CreateMap<DisplayOurSpecialResponse,OurSpecial>().ReverseMap();
            CreateMap<DisplayStatisticResponse,Statistic>().ReverseMap();
            CreateMap<DisplayWelcomeBannerResponse,WelcomeBanner>().ReverseMap();
        }
    }
}

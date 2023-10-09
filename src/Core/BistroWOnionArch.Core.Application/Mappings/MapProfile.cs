using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.About.Requests;
using BistroWOnionArch.Core.Application.Dtos.About.Responses;
using BistroWOnionArch.Core.Application.Dtos.Category.Requests;
using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.Dish.Requests;
using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Requests;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurService.Requests;
using BistroWOnionArch.Core.Application.Dtos.OurService.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Requests;
using BistroWOnionArch.Core.Application.Dtos.OurSpecial.Responses;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Requests;
using BistroWOnionArch.Core.Application.Dtos.Statistic.Responses;
using BistroWOnionArch.Core.Application.Dtos.WelcomeBanner.Requests;
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

            CreateMap<CreateAboutRequest, About>().ReverseMap();
            CreateMap<CreateCategoryRequest, Category>().ReverseMap();
            CreateMap<CreateDishRequest, Dish>().ReverseMap();
            CreateMap<CreateOurDishRequest, OurDish>().ReverseMap();
            CreateMap<CreateOurServiceRequest, OurService>().ReverseMap();
            CreateMap<CreateOurSpecialRequest, OurSpecial>().ReverseMap();
            CreateMap<CreateStatisticRequest, Statistic>().ReverseMap();
            CreateMap<CreateWelcomeBannerRequest, WelcomeBanner>().ReverseMap();

            CreateMap<UpdateAboutRequest, About>().ReverseMap();
            CreateMap<UpdateCategoryRequest, Category>().ReverseMap();
            CreateMap<UpdateDishRequest, Dish>().ReverseMap();
            CreateMap<UpdateOurDishRequest, OurDish>().ReverseMap();
            CreateMap<UpdateOurServiceRequest, OurService>().ReverseMap();
            CreateMap<UpdateOurSpecialRequest, OurSpecial>().ReverseMap();
            CreateMap<UpdateStatisticRequest, Statistic>().ReverseMap();
            CreateMap<UpdateWelcomeBannerRequest, WelcomeBanner>().ReverseMap();
        }
    }
}

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

namespace BistroWOnionArch.Core.Application.Dtos.Category.Responses
{
    public class DisplayCategoryResponse
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}



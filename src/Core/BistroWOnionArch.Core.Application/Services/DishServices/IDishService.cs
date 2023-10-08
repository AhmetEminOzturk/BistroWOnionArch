using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
using BistroWOnionArch.Core.Application.Dtos.OurDish.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.DishServices
{
    public interface IDishService 
    {       
        Task<List<DisplayDishResponse>> GetDishesByCategory(int categoryId);
        Task<List<DisplayDishResponse>> TGetAll();
    }
}

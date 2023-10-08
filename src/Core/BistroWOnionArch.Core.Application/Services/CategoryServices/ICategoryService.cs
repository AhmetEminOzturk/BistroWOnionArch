using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
using BistroWOnionArch.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.CategoryServices
{
    public interface ICategoryService 
    {
        Task<List<DisplayCategoryResponse>> TGetAll();
    }
}

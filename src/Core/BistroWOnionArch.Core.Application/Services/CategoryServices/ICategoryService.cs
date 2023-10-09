using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.Category.Requests;
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
        Task<DisplayCategoryResponse> TGet(int id);
        Task TInsert(CreateCategoryRequest createCategoryRequest);
        Task TUpdate(UpdateCategoryRequest updateCategoryRequest);
        Task TDelete(int id);
    }
}

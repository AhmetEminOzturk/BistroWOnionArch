using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<DisplayCategoryResponse>> TGetAll()
        {
            var values = await _categoryRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayCategoryResponse>>(values);
            return response;
        }
    }
}

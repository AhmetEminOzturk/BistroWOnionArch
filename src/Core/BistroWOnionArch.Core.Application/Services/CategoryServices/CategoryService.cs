using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.Category.Responses;
using BistroWOnionArch.Core.Application.Dtos.Category.Requests;
using BistroWOnionArch.Core.Domain.Entities;
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

        public async Task<DisplayCategoryResponse> TGet(int id)
        {
            var value = await _categoryRepository.GetAsync(id);
            var response = _mapper.Map<DisplayCategoryResponse>(value);
            return response;
        }

        public async Task TDelete(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayCategoryResponse>> TGetAll()
        {
            var values = await _categoryRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayCategoryResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateCategoryRequest createCategoryRequest)
        {
            var value = _mapper.Map<Category>(createCategoryRequest);
            await _categoryRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateCategoryRequest updateCategoryRequest)
        {
            var value = _mapper.Map<Category>(updateCategoryRequest);
            await _categoryRepository.UpdateAsync(value);
        }
    }
}

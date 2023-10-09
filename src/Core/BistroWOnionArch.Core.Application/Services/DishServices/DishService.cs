using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
using BistroWOnionArch.Core.Application.Dtos.Dish.Requests;
using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Repositories.DishRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services.DishServices
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public DishService(IDishRepository dishRepository, IMapper mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }

        public async Task<List<DisplayDishResponse>> GetDishesByCategory(int categoryId)
        {
            var values = await _dishRepository.GetDishesByCategoryAsync(categoryId);
            var response = _mapper.Map<List<DisplayDishResponse>>(values);
            return response;
        }

        public async Task TDelete(int id)
        {
            await _dishRepository.DeleteAsync(id);
        }

        public async Task<List<DisplayDishResponse>> TGetAll()
        {
            var values = await _dishRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayDishResponse>>(values);
            return response;
        }

        public async Task TInsert(CreateDishRequest createDishRequest)
        {
            var value = _mapper.Map<Dish>(createDishRequest);
            await _dishRepository.CreateAsync(value);
        }

        public async Task TUpdate(UpdateDishRequest updateDishRequest)
        {
            var value = _mapper.Map<Dish>(updateDishRequest);
            await _dishRepository.UpdateAsync(value);
        }
    }
}

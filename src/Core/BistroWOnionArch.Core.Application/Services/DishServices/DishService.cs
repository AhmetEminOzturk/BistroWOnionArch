﻿using AutoMapper;
using BistroWOnionArch.Core.Application.Dtos.Dish.Responses;
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
        public async Task<List<DisplayDishResponse>> GetDishesByCategory(int categoryId)
        {
            var values = await _dishRepository.GetDishesByCategoryAsync(categoryId);
            var response = _mapper.Map<List<DisplayDishResponse>>(values);
            return response;
        }

        public async Task<List<DisplayDishResponse>> TGetAll()
        {
            var values = await _dishRepository.GetAllAsync();
            var response = _mapper.Map<List<DisplayDishResponse>>(values);
            return response;
        }
    }
}
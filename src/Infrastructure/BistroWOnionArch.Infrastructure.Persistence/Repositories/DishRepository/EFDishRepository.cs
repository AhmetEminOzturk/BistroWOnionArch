using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.DishRepository
{
    public class EFDishRepository : IDishRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFDishRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Dish entity)
        {
            await _dbContext.Dishes.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.Dishes.FindAsync(id);
            _dbContext.Dishes.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Dish?>> GetAllAsync()
        {
            return await _dbContext.Dishes.ToListAsync();
        }

        public async Task<Dish?> GetAsync(int id)
        {
            return await _dbContext.Dishes.FirstAsync(p => p.DishId == id);
        }

        public Task<List<Dish>> GetDishesByCategoryAsync(int categoryId)
        {
            return _dbContext.Dishes.Where(c => c.Category.CategoryId == categoryId).ToListAsync();
        }

        public async Task UpdateAsync(Dish entity)
        {
            _dbContext.Dishes.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

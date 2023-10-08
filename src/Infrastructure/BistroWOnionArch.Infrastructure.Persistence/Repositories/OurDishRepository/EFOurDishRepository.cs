using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.OurDishRepository
{
    public class EFOurDishRepository : IOurDishRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFOurDishRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(OurDish entity)
        {
            await _dbContext.OurDishes.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.OurDishes.FindAsync(id);
            _dbContext.OurDishes.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<OurDish?>> GetAllAsync()
        {
            return await _dbContext.OurDishes.ToListAsync();
        }

        public async Task<OurDish?> GetAsync(int id)
        {
            return await _dbContext.OurDishes.FirstAsync(p => p.OurDishId == id);
        }

        public async Task UpdateAsync(OurDish entity)
        {
            _dbContext.OurDishes.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

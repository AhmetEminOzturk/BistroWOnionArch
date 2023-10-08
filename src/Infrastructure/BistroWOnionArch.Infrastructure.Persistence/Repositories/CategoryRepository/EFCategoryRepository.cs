using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.CategoryRepository
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFCategoryRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Category entity)
        {
            await _dbContext.Categories.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.Categories.FindAsync(id);
            _dbContext.Categories.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Category?>> GetAllAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await _dbContext.Categories.FirstAsync(p => p.CategoryId == id);
        }

        public async Task UpdateAsync(Category entity)
        {
            _dbContext.Categories.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

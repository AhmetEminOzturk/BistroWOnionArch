using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.AboutRepository
{
    public class EFAboutRepository : IAboutRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFAboutRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(About entity)
        {
            await _dbContext.Abouts.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.Abouts.FindAsync(id);
            _dbContext.Abouts.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<About?>> GetAllAsync()
        {
            return await _dbContext.Abouts.ToListAsync();
        }

        public async Task<About?> GetAsync(int id)
        {
            return await _dbContext.Abouts.FirstAsync(p => p.AboutId == id);
        }

        public async Task UpdateAsync(About entity)
        {
            _dbContext.Abouts.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

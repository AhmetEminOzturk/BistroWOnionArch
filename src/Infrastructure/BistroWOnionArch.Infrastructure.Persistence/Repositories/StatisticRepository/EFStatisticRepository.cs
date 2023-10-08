using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.StatisticRepository
{
    public class EFStatisticRepository : IStatisticRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFStatisticRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Statistic entity)
        {
            await _dbContext.Statistics.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.Statistics.FindAsync(id);
            _dbContext.Statistics.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Statistic?>> GetAllAsync()
        {
            return await _dbContext.Statistics.ToListAsync();
        }

        public async Task<Statistic?> GetAsync(int id)
        {
            return await _dbContext.Statistics.FirstAsync(p => p.StatisticId == id);
        }

        public async Task UpdateAsync(Statistic entity)
        {
            _dbContext.Statistics.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

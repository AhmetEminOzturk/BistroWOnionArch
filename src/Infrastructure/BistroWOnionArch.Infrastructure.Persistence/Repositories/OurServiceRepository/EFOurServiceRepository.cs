using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.OurServiceRepository
{
    public class EFOurServiceRepository : IOurServiceRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFOurServiceRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(OurService entity)
        {
            await _dbContext.OurServices.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.OurServices.FindAsync(id);
            _dbContext.OurServices.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<OurService?>> GetAllAsync()
        {
            return await _dbContext.OurServices.ToListAsync();
        }

        public async Task<OurService?> GetAsync(int id)
        {
            return await _dbContext.OurServices.FirstAsync(p => p.OurServiceId == id);
        }

        public async Task UpdateAsync(OurService entity)
        {
            _dbContext.OurServices.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

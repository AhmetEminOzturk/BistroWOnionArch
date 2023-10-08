using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.OurSpecialRepository
{
    public class EFOurSpecialRepository : IOurSpecialRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFOurSpecialRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(OurSpecial entity)
        {
            await _dbContext.OurSpecials.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.OurSpecials.FindAsync(id);
            _dbContext.OurSpecials.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<OurSpecial?>> GetAllAsync()
        {
            return await _dbContext.OurSpecials.ToListAsync();
        }

        public async Task<OurSpecial?> GetAsync(int id)
        {
            return await _dbContext.OurSpecials.FirstAsync(p => p.OurSpecialId == id);
        }

        public async Task UpdateAsync(OurSpecial entity)
        {
            _dbContext.OurSpecials.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

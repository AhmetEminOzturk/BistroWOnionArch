using BistroWOnionArch.Core.Domain.Entities;
using BistroWOnionArch.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Repositories.WelcomeBannerRepository
{
    public class EFWelcomeBannerRepository : IWelcomeBannerRepository
    {
        private readonly BistroWOnionArchDbContext _dbContext;

        public EFWelcomeBannerRepository(BistroWOnionArchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(WelcomeBanner entity)
        {
            await _dbContext.WelcomeBanners.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await _dbContext.WelcomeBanners.FindAsync(id);
            _dbContext.WelcomeBanners.Remove(deleting);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<WelcomeBanner?>> GetAllAsync()
        {
            return await _dbContext.WelcomeBanners.ToListAsync();
        }

        public async Task<WelcomeBanner?> GetAsync(int id)
        {
            return await _dbContext.WelcomeBanners.FirstAsync(p => p.WelcomeBannerId == id);
        }

        public async Task UpdateAsync(WelcomeBanner entity)
        {
            _dbContext.WelcomeBanners.Update(entity);
            _dbContext.SaveChangesAsync();
        }
    }
}

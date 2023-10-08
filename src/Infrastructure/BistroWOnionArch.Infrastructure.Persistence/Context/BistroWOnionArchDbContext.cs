using BistroWOnionArch.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Infrastructure.Persistence.Context
{
    public class BistroWOnionArchDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433;database=BistroWOnionArchDb;user=sa;password=123456aA*;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<OurDish> OurDishes { get; set; }
        public DbSet<OurService> OurServices { get; set; }
        public DbSet<OurSpecial> OurSpecials { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<WelcomeBanner> WelcomeBanners { get; set; }
    }
}

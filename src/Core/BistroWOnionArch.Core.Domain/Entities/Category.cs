using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int Name { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}

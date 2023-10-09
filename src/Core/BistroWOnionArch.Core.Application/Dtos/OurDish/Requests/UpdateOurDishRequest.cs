using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Dtos.OurDish.Requests
{
    public class UpdateOurDishRequest
    {
        public int OurDishId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Dish1 { get; set; }
        public string Dish2 { get; set; }
        public string Dish3 { get; set; }
        public decimal DishPrice1 { get; set; }
        public decimal DishPrice2 { get; set; }
        public decimal DishPrice3 { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
    }
}

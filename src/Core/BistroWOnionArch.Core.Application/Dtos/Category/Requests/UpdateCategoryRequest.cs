using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Dtos.Category.Requests
{
    public class UpdateCategoryRequest
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}

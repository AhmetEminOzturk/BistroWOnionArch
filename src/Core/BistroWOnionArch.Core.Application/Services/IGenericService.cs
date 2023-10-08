using BistroWOnionArch.Core.Application.Dtos.About.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BistroWOnionArch.Core.Application.Services
{
    public interface IGenericService <T> where T : class
    {
        Task<List<T>> TGetAll();
    }
}

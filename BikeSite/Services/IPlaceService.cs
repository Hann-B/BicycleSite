using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeSite.Services
{
    public interface IPlaceService
    {
        Task<object> GetTopDestinations();
    }
}

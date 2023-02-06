using core_lab2.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace core_lab2.dao
{
    public interface IRatesDynamicDAO
    {
        Task<IEnumerable<RateShort>> GetRateShorts(HttpClient httpClient, Rate rate, DateTime dateStart, DateTime dateEnd);
    }
}

using core_lab2.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace core_lab2.dao.impl
{
    public class RatesDynamicDAOImpl : IRatesDynamicDAO
    {
        private static string request;
        public async Task<IEnumerable<RateShort>> GetRateShorts(HttpClient httpClient, 
            Rate rate, DateTime dateStart, DateTime dateEnd)
        {
            DateTime denominationDate = new DateTime(2016, 7, 1);
            if (dateStart < denominationDate && dateEnd < denominationDate)
            {
                throw new ArgumentOutOfRangeException();
            }
            request = "api/exrates/rates/dynamics/" + 
                rate.Cur_ID + "?startDate=" + dateStart.ToString("yyyy-M-d") + "&endDate=" + dateEnd.ToString("yyyy-M-d");
            string ratesDynamicsString = null;
            HttpResponseMessage response = await httpClient.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                ratesDynamicsString = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<IEnumerable<RateShort>>(ratesDynamicsString);
        }
    }
}

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
    public class RatesDAOImpl : IRatesDAO
    {
        private static string request;
        public async Task<Rate> GetRateByCurAbbreviation(HttpClient httpClient, string abbr)
        {
            request = "api/exrates/rates/" + abbr + "?parammode=2";
            string rate = null;
            HttpResponseMessage response = await httpClient.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                rate = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<Rate>(rate);
        }

        public async Task<IEnumerable<Rate>> GetRates(HttpClient httpClient)
        {
            request = "api/exrates/rates/?periodicity=0";
            string ratesString = null;
            HttpResponseMessage response = await httpClient.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                ratesString = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<IEnumerable<Rate>>(ratesString);
        }
    }
}

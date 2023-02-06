using core_lab2.entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace core_lab2.dao.impl
{
    public class CurrencyDAOImpl : ICurrencyDAO
    {
        private static string request;
        public async Task<IEnumerable<Currency>> GetCurrencies(HttpClient httpClient)
        {
            request = "api/exrates/currencies/";
            string currenciesString = null;
            HttpResponseMessage response = await httpClient
                .GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                currenciesString = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<IEnumerable<Currency>>(currenciesString);
        }

        public async Task<Currency> GetCurrency(HttpClient httpClient, int id)
        {
            request = "api/exrates/currencies/" + id;
            string currency = null;
            HttpResponseMessage response = await httpClient
                .GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                currency = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<Currency>(currency);
        }
    }
}

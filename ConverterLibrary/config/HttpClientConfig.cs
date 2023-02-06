using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace core_lab2.config
{
    public class HttpClientConfig
    {
        private HttpClient client = new HttpClient();
        private static HttpClientConfig instance;
        
        private HttpClientConfig()
        {
            client.BaseAddress = new Uri("https://www.nbrb.by/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
        }

        public static HttpClientConfig getInstance()
        {
            if (instance == null)
                instance = new HttpClientConfig();
            return instance;
        }

        public HttpClient GetHttpClient()
        {
            return client;
        }
    }
}

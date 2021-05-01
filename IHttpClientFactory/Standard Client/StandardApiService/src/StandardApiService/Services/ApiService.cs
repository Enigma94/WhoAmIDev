using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StandardApiService.Interfaces;

namespace StandardApiService.Services
{
    public class ApiService : IApiService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ApiService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<WebResponse<T>> GetAsync<T>(string searchQuery)
        {
            var request = $"https://api.duckduckgo.com/?q={searchQuery}&format=json";
            T responseModel = default;

            try
            {
                var client = _clientFactory.CreateClient();

                var response = await client.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    using var stream = await response.Content.ReadAsStreamAsync();
                    using (StreamReader sr = new StreamReader(stream))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        responseModel = serializer.Deserialize<T>(reader);
                    }
                }

                return new WebResponse<T>(responseModel, response.IsSuccessStatusCode);
            }
            catch (Exception ex)
            {
                return new WebResponse<T>(default, false, ex.ToString());
            }
        }
    }
}

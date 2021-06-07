using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TypedApiService.Interfaces;

namespace TypedApiService.Services
{
    public class TypedService : ITypedService
    {
        private readonly HttpClient _httpClient;

        public TypedService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WebResponse<T>> GetAsync<T>(string searchQuery)
        {
            var request = $"/?q={searchQuery}&format=json";
            T responseModel = default;

            try
            {
                var response = await _httpClient.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    responseModel = JsonConvert.DeserializeObject<T>(content);
                }

                return new WebResponse<T>(true, responseModel);
            }
            catch (Exception ex)
            {
                return new WebResponse<T>(false, responseModel, ex.ToString());
            }
        }
    }
}

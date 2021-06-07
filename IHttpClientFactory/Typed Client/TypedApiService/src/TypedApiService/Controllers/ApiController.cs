using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TypedApiService.Interfaces;
using TypedApiService.Models;

namespace TypedApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ITypedService _apiService;

        public ApiController(ITypedService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Search any topic on DuckDuckGo
        /// </summary>
        /// <param name="query"></param>
        /// <returns>DuckDuckGo model with information on the search</returns>
        /// <response code="200">Request was successful with returning response</response>
        /// <response code="500">An error occured internally</response>
        [HttpGet]
        [Route("/v1/search/{query}")]
        public async Task<ActionResult> Get(string query)
        {
            var response = await _apiService.GetAsync<DuckDuckGoModel>(query);

            if (!response.IsSuccessful)
                return StatusCode(500);

            return Ok(response.Payload);
        }
    }
}

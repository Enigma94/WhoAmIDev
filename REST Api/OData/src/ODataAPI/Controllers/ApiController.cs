using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Interfaces;
using ODataAPI.Models;

namespace ODataAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly IApiService _apiService;

        public ApiController(IApiService apiService)
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

            return Ok(response.Payload);
        }
    }
}

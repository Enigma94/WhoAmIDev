using System.Threading.Tasks;

namespace ODataAPI.Interfaces
{
    public interface IApiService
    {
        Task<WebResponse<T>> GetAsync<T>(string searchQuery);
    }
}

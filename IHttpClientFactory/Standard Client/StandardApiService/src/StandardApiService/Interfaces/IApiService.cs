using System.Threading.Tasks;

namespace StandardApiService.Interfaces
{
    public interface IApiService
    {
        Task<WebResponse<T>> GetAsync<T>(string searchQuery);
    }
}

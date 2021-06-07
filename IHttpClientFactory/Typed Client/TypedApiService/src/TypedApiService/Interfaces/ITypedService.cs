using System.Threading.Tasks;

namespace TypedApiService.Interfaces
{
    public interface ITypedService
    {
        Task<WebResponse<T>> GetAsync<T>(string searchQuery);
    }
}

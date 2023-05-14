using Web.Model;

namespace Web.Services.IShortnerService;

public interface IService: IBaseService
{
    Task<IEnumerable<object>> GetUrlBySlug(string slug);
    Task<IEnumerable<object>> GetAllUrlGenerated();
    Task<OutputUrl> CreateUrl(InputUrl url);
    Task<OutputUrl> UpdateUrl(InputUrl url);
    Task<bool> DeleteUrl(InputUrl url);
    Task<bool> DeleteUrlById(int id);
    /*Task<T> DeleteUrlGenerated<T>();*/


}

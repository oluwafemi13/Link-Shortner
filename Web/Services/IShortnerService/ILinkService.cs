using Web.Model;

namespace Web.Services.IShortnerService;

public interface ILinkService: IBaseService
{
    Task<IEnumerable<T>> GetUrlBySlug<T>(string slug);
    Task<IEnumerable<T>> GetAllUrlGenerated<T>();
    Task<string> CreateUrl<T>(InputUrl url);
    Task<T> UpdateUrl<T>(InputUrl url);
    Task<T> DeleteUrl<T>(InputUrl url);
    Task<T> DeleteUrlById<T>(int id);
    /*Task<T> DeleteUrlGenerated<T>();*/


}

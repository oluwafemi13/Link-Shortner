namespace Web.Services.IShortnerService
{
    public interface IService
    {
        Task<IEnumerable<string>> GetUrlBySlug(string slug);
        Task<IEnumerable<string>> GetAllUrlGenerated();
        Task<T> CreateUrl<T>();
        Task<T> UpdateUrl<T>();
        Task<T> DeleteUrl<T>();
        /*Task<T> DeleteUrlGenerated<T>();*/


    }
}

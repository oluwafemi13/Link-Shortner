using Web.Model;

namespace Web.Services.IShortnerService
{
    public interface IBaseService: IDisposable
    {
        //OutputUrl responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest request);
    }
}

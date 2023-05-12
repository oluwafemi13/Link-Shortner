using Web.Model;

namespace Web.Services.IShortnerService
{
    public interface IBaseService: IDisposable
    {
        //OutputUrl responseModel { get; set; }
        Task SendAsync(ApiRequest request);
    }
}

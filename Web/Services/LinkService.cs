using Web.Model;
using Web.Services.IShortnerService;
using Web.Static_Data;

namespace Web.Services
{
    public class LinkService :BaseService, ILinkService
    {
        public LinkService(IHttpClientFactory httpClient) : base(httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<T> CreateUrl<T>(InputUrl url)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                Url = SD.ApiBase,
                Data = url.UrlInput + "/shorten",
                Method=ApiMethods.POST
            });
        }

        public Task<T> DeleteUrl<T>(InputUrl url)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteUrlById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllUrlGenerated<T>()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetUrlBySlug<T>(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateUrl<T>(InputUrl url)
        {
            throw new NotImplementedException();
        }
    }
}

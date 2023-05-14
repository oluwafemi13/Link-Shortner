using Web.Model;
using Web.Services.IShortnerService;

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

            });
        }

        public Task<bool> DeleteUrl(InputUrl url)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUrlById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetAllUrlGenerated()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<object>> GetUrlBySlug(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<OutputUrl> UpdateUrl(InputUrl url)
        {
            throw new NotImplementedException();
        }
    }
}

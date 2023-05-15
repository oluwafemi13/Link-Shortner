using Microsoft.EntityFrameworkCore;
using Web.Model;
using Web.Services.IShortnerService;
using Web.Static_Data;

namespace Web.Services
{
    public class LinkService :BaseService, ILinkService
    {
        private readonly ApplicationDbContext _db;

        public LinkService(IHttpClientFactory httpClient, ApplicationDbContext db) : base(httpClient)
        {
            this._httpClient = httpClient;
            _db = db;
        }

        public async Task<T> CreateUrl<T>(InputUrl url)
        {
            var search = await  _db.Urls.FindAsync(url.UrlInput);
            if (search != null)
            {
                new Response
                {
                    DisplayMessage = "Url Already Exist",
                    IsSuccess = false,
                    ErrorMessage = string.Empty
                };
            }

             await _db.Urls.AddAsync(url);
            await _db.SaveChangesAsync();
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

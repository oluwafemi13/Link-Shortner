using Web.Model;
using Web.Services.IShortnerService;

namespace Web.Services
{
    public class Service : IService
    {
        public Task<OutputUrl> CreateUrl(InputUrl url)
        {
            throw new NotImplementedException();
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

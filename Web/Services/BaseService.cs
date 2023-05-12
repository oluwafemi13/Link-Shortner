using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using Web.Model;
using Web.Services.IShortnerService;
using Web.Static_Data;

namespace Web.Services
{
    public class BaseService : IBaseService
    {
       
        public OutputUrl responseModel { get; set; }
        public IHttpClientFactory _httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
            this.responseModel = new OutputUrl();
            
        }


        public async Task<object> SendAsync(ApiRequest request)
        {
            try
            {
                var client = _httpClient.CreateClient("UrlShortner");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(request.Url);
                client.DefaultRequestHeaders.Clear();
                if(request.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(request.Data),Encoding.UTF8,"application/json");
                }
                HttpResponseMessage response = null;
                switch (request.Method)
                {
                    case ApiMethods.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiMethods.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case ApiMethods.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    case ApiMethods.PATCH:
                        message.Method = HttpMethod.Patch;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                response = await client.SendAsync(message);
                var apiContent = await response.Content.ReadAsStringAsync();
                var finalResponse = JsonConvert.DeserializeObject(apiContent);
                return finalResponse;
                   

            }
            catch (Exception ex)
            {

                var response = new Response
                {
                    ErrorMessage = ex.Message,
                    DisplayMessage = "",
                    IsSuccess = false
                    
                };
                return response;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

       
    }
}

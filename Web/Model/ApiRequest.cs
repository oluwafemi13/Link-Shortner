using Web.Static_Data;

namespace Web.Model
{
    public class ApiRequest
    {
        public ApiMethods Method { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        //public string AccessToken { get; set; }
    }
}

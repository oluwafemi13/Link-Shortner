using System.ComponentModel.DataAnnotations;

namespace Web.Model
{
    public class InputUrl
    {
        public int Id { get; set; }
        public string? Slug { get; set; }
        
        public string UrlInput { get; set; } 
        //public string OutputUrl { get; set; }
        //public string DeleteToken { get; set; }
        public OutputUrl outputUrl { get; set; }
    }
}

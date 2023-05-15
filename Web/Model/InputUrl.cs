using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using static System.Net.WebRequestMethods;

namespace Web.Model
{
    public class InputUrl
    {
        public int Id { get; set; }

        [ValidateNever]
        public string? Slug { get; set; }

        [Required]
        public string UrlInput { get; set; }
        //public string OutputUrl { get; set; }
        //public string DeleteToken { get; set; }

        public OutputUrl outputUrl { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Web.Model;
using Web.Services.IShortnerService;

namespace Web.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILinkService _linkService;

        public IndexModel(ILogger<IndexModel> logger, ILinkService linkService)
        {
            _logger = logger;
            _linkService = linkService;
        }


        public class InputModel
        {
            public int id { get; set; }
            [Required]
            public string Url { get; set; }
            [ValidateNever]
            [Required]
            public string Slug { get; set; }

        }
        //public OutputUrl url { get; set; }
        public InputModel input { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var value = input.Url;
                if (value == null)
                {
                    RedirectToPage("Index");
                }
                var inputUrl = new InputUrl
                {
                    Id = input.id,
                    Slug = input.Slug,
                    UrlInput = input.Url
                };
                var result =  _linkService.CreateUrl<InputUrl>(inputUrl);

            }
            return RedirectToPage("Result");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public OutputUrl url { get; set; }
        public InputUrl input { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var value = input.UrlInput;
                if (value == null)
                {
                    RedirectToPage("Index");
                }

            }
            return RedirectToPage("Delete");
        }
    }
}
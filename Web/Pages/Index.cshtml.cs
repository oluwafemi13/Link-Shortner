using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Model;

namespace Web.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public OutputUrl url { get; set; }

        public void OnGet()
        {

        }

       /* public async Task<InputUrl> OnPost()
        {
            
        }*/
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace CreateImages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public String statusMessage = "";
        public IndexModel(ILogger<IndexModel> logger)
        {

            _logger = logger;

        }

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            var input_text = Request.Form["input_text"];
            Response.Redirect("GenerateImage?text=" + input_text);
        }

    }
}
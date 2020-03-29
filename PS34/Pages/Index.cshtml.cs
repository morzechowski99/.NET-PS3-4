using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PS34.Models;

namespace PS34.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Person person { get; set;}
        
        public bool cm { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(Person person)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Request.Form["cm"] == "true")
            {
                person.height /= 100;
            }
            return RedirectToPage("Test",person);
        }

    }
}

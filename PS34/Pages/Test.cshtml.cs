using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS34.Models;

namespace PS34.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public Person person { get; set; }
        public double BMI { get; set; }
        public void OnGet()
        {
            BMI = Math.Round(person.weight / (person.height * person.height),3);
        }
    }
}

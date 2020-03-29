using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PS34.Models
{
    public class Person
    {
        [Display(Name = "Imię")]
        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Zły format imienia")]
        [Required(ErrorMessage = "Imię jest obowiązkowe")]
        [StringLength(15)]
        public string firstName { get; set; }
        [Display(Name = "Email")]
        [EmailAddress (ErrorMessage = "To nie jest adres email")]
        public string email { get; set; }
        [Display(Name = "Wiek")]
        
        [Range(1,120,ErrorMessage ="Podano watość spoza zakresu [1-120]")]
        public int? age { get; set; }
        [Display(Name = "Waga (kg)")]
        [Required(ErrorMessage = "Waga jest obowiązkowa")]
        
     
        public double weight { get; set; }
        [Display(Name = "Wzrost")]
        [Required(ErrorMessage = "Wzrost jest obowiązkowy")]
       
        public double height { get; set; }
        [Display(Name = "Płeć")]
        public string gender { get; set; }
    }
}

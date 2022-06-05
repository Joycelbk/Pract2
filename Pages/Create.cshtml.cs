using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pract2.Models;


namespace Pract2.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Employee MyEmployee { get;  set; }
        public void OnGet()
        {

        }
 
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
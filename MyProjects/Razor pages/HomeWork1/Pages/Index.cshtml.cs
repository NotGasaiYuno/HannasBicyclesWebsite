using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork1.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "Hello world!";
        public void OnGet()
        {
        }
    }
}
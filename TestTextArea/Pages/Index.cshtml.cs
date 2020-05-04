using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TestTextArea.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty, MaxLength(300)]
        public string MainText { get; set; }

        public void OnGet()
        {
            MainText = "GetTest";
        }

        public void OnPost()
        {
            MainText = "PostTest";
        }
    }
}
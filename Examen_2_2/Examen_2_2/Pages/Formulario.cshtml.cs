﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen_2_2.Pages
{
    public class FormularioModel : PageModel
    {
        [BindProperty]
        public int Masa { set; get; }

        [BindProperty]
        public int Tamano { get; set; }

        public IActionResult OnPost()
        {
            return Page();
        }

        public void OnGet()
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mindrusca_Stefania_Laborator2.Data;
using Mindrusca_Stefania_Laborator2.Models;

namespace Mindrusca_Stefania_Laborator2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Mindrusca_Stefania_Laborator2.Data.Mindrusca_Stefania_Laborator2Context _context;

        public DetailsModel(Mindrusca_Stefania_Laborator2.Data.Mindrusca_Stefania_Laborator2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}

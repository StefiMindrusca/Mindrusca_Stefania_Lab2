using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mindrusca_Stefania_Laborator2.Data;
using Mindrusca_Stefania_Laborator2.Models;

namespace Mindrusca_Stefania_Laborator2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Mindrusca_Stefania_Laborator2.Data.Mindrusca_Stefania_Laborator2Context _context;

        public IndexModel(Mindrusca_Stefania_Laborator2.Data.Mindrusca_Stefania_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}

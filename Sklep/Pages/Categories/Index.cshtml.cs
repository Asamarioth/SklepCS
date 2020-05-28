using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sklep.Data;
using Sklep.Models;

namespace Sklep.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public IndexModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public IList<Kategorie> Kategorie { get;set; }

        public async Task OnGetAsync()
        {
            Kategorie = await _context.Kategorie
                .Include(p=>p.Produkty)
                .ToListAsync();
        }
    }
}

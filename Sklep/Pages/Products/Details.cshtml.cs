using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sklep.Data;
using Sklep.Models;

namespace Sklep.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public DetailsModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public Produkty Produkty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produkty = await _context.Produkty.FirstOrDefaultAsync(m => m.ID == id);

            if (Produkty == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
    public class DeleteModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public DeleteModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produkty = await _context.Produkty.FindAsync(id);

            if (Produkty != null)
            {
                _context.Produkty.Remove(Produkty);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

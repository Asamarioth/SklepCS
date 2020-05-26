using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sklep.Data;
using Sklep.Models;

namespace Sklep.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public EditModel(Sklep.Data.SklepContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Produkty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduktyExists(Produkty.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProduktyExists(int id)
        {
            return _context.Produkty.Any(e => e.ID == id);
        }
    }
}

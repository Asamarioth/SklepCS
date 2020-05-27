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
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produkty = await _context.Produkty
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Produkty == null)
            {
                return NotFound();
            }
            if(saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = "Usuwanie się nie powiodło";
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produkt = await _context.Produkty.FindAsync(id);

            if (produkt == null)
            {
                return NotFound();
            }

            try
            {
                _context.Produkty.Remove(produkt);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch(DbUpdateException)
            {
                return RedirectToAction("./Delete",
                    new { id, saveChangesError = true });
            }
           
        }
    }
}

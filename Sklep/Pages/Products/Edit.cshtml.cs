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

            Produkty = await _context.Produkty.FindAsync(id);

            if (Produkty == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var produktToUpdate = await _context.Produkty.FindAsync(id);

            if(produktToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Produkty>(
         produktToUpdate,
         "produkty",   // Prefix for form value.
         p => p.Id_kategorii, p => p.Id_producenta, p => p.Nazwa, p => p.Cena_netto, p => p.VAT, p => p.Cena_brutto, p => p.Opis, p => p.Obrazek))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }

        private bool ProduktyExists(int id)
        {
            return _context.Produkty.Any(e => e.ID == id);
        }
    }
}

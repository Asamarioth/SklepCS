using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sklep.Data;
using Sklep.Models;

namespace Sklep.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public CreateModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Produkty Produkty { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            var emptyProdukt = new Produkty();

            if (await TryUpdateModelAsync<Produkty>(
         emptyProdukt,
         "produkty",   // Prefix for form value.
         p => p.Id_kategorii, p => p.Id_producenta, p => p.Nazwa, p => p.Cena_netto, p => p.VAT, p => p.Cena_brutto, p => p.Opis, p => p.Id_obrazek))
            {
                _context.Produkty.Add(emptyProdukt);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}

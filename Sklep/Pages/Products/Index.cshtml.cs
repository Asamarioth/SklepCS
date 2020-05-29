using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sklep.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Sklep.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public IndexModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public int CurrentProduct { get; set; }

        public IList<Produkty> Produkty { get; set; }

        public async Task OnGetAsync(string productID)
        {
            
            CurrentProduct = String.IsNullOrEmpty(productID) ? 1: Int32.Parse(productID);



            IQueryable<Produkty> produktyIQ = from p in _context.Produkty
                                              .Include(k => k.Kategorie)
                                              .Include(p => p.Producenci)
                                              select p;

            produktyIQ = produktyIQ.Where(p => p.ID.Equals(CurrentProduct));

            Produkty = await produktyIQ.ToListAsync();
            
        }
    }
}
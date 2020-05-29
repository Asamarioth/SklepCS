using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sklep.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Sklep.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public IndexModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public int CurrentCategory { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public string ErrorMessage { get; set; }

        public IList<Kategorie> Kategorie { get; set; }
        public PaginatedList<Produkty> Produkty { get; set; }
        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex, string currentCategory = "0")
        {
            CurrentSort = sortOrder;
            CurrentCategory = Int32.Parse(currentCategory);
            PriceSort = sortOrder == "Price" ? "price_desc" : "Price";
            
            CurrentFilter = searchString;


            IQueryable<Produkty> produktyIQ = from p in _context.Produkty
                                              .Include(ka => ka.Kategorie)
                                              select p;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                if (Int32.Parse(currentCategory)!= 0)
                {
                    produktyIQ = produktyIQ
                        .Where(p => p.Nazwa.Contains(searchString))
                        .Where(p => p.Kategorie.ID.Equals(Int32.Parse(currentCategory)));
                }
                else
                {  
                    
                    produktyIQ = produktyIQ
                        .Where(p => p.Nazwa.Contains(searchString));
                }
            }
            else
            {
                if (Int32.Parse(currentCategory) != 0)
                {
                    produktyIQ = produktyIQ                      
                        .Where(p => p.Kategorie.ID.Equals(Int32.Parse(currentCategory)));
                }

            }
            switch (sortOrder)
            {
                case "price_asc":
                    produktyIQ = produktyIQ.OrderBy(p => p.Cena_brutto);
                    break;

                case "price_desc":
                    produktyIQ = produktyIQ.OrderByDescending(p => p.Cena_brutto);
                    break;

                default:
                    produktyIQ = produktyIQ.OrderBy(p => p.Nazwa);
                    break;
            }

            int pageSize = 9;
            Produkty = await PaginatedList<Produkty>.CreateAsync(
                produktyIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
            Kategorie = await _context.Kategorie
                .Include(p => p.Produkty)
                .ToListAsync();
        }
    }
}
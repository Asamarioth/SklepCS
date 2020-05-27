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
    public class IndexModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public IndexModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string PriceSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Produkty> Produkty { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter, int? pageIndex)
        {
            CurrentSort = sortOrder;
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PriceSort = sortOrder == "Price" ? "price_desc" : "Price";

            CurrentFilter = searchString;

            IQueryable<Produkty> produktyIQ= from p in _context.Produkty
                                             select p;

            if(searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            if(!String.IsNullOrEmpty(searchString))
            {
                produktyIQ = produktyIQ.Where(p => p.Nazwa.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    produktyIQ = produktyIQ.OrderByDescending(p => p.Nazwa);
                    break;
                case "Price":
                    produktyIQ = produktyIQ.OrderBy(p => p.Cena_brutto);
                    break;
                case "price_desc":
                    produktyIQ = produktyIQ.OrderByDescending(p => p.Cena_brutto);
                    break;
                default:
                    produktyIQ = produktyIQ.OrderBy(p => p.Nazwa);
                    break;
            }
            int pageSize = 10;
            Produkty = await PaginatedList<Produkty>.CreateAsync(
                produktyIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}

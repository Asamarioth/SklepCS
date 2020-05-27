using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sklep.Models;
using Sklep.Models.SklepViewModels;
using Sklep.Data;
using Microsoft.EntityFrameworkCore;
namespace Sklep.Pages
{
    public class AboutModel : PageModel
    {
        private readonly SklepContext _context;

        public AboutModel(SklepContext context)
        {
            _context = context;
        }
        public IList<KategorieProdukty> Produkty { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<KategorieProdukty> data =
                from produkty in _context.Produkty
                group produkty by produkty.Id_kategorii into kategoriaGroup
                select new KategorieProdukty()
                {
                    Id = kategoriaGroup.Key,
                    ProduktyCount = kategoriaGroup.Count(),
                    Nazwa = (from Kategorie in _context.Kategorie
                             where (Kategorie.ID == kategoriaGroup.Key)
                             select Kategorie.Nazwa).Single()

                };
            Produkty = await data.AsNoTracking().ToListAsync();
        }
    }
}
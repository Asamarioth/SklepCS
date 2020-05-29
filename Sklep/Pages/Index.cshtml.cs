using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;
using Sklep.Data;
using Sklep.Models;
using Sklep.Models.SklepViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Sklep.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SklepContext _context;

        public IndexModel(SklepContext context)
        {
            _context = context;
        }


        public IList<KategorieProdukty> KatProd { get; set; }
        public IList<Produkty> Produkty { get; set; }
        public List<int> RandomList { get; set; }
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
            KatProd = await data.AsNoTracking().ToListAsync();
            Produkty = await _context.Produkty.ToListAsync();

            Random a = new Random();
            RandomList = new List<int>();
            int temp = 0;
            while (RandomList.Count<10)
            {
                temp = a.Next(1, Produkty.Count - 1);
                if (!RandomList.Contains(temp))
                {
                    RandomList.Add(temp);
                }
            }
        }
    }
}
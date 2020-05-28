using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;
using Sklep.Data;
using Sklep.Models;
using Sklep.Models.SklepViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Sklep.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SklepContext _context;

        public IndexModel(SklepContext context)
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
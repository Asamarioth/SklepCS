using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public partial class Produkty
    {
        public int ID { get; set; }
        public int Id_kategorii { get; set; }
        public int Id_producenta { get; set; }
        public string Nazwa { get; set; }
        public Nullable<decimal> Cena_netto { get; set; }
        public int VAT { get; set; }
        public decimal Cena_brutto { get; set; }
        public string Opis { get; set; }
        public string Id_obrazek { get; set; }

        public virtual Kategorie Kategorie { get; set; }
        public virtual Producenci Producenci { get; set; }
    }
}

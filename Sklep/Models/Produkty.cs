using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Models
{
    public partial class Produkty
    {
        public int ID { get; set; }
        [ForeignKey("Kategorie")]
        [Required]
        public int Id_kategorii { get; set; }
        [ForeignKey("Producenci")]
        [Required]
        public int Id_producenta { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        [Display(Name = "Cena netto")]
        public Nullable<decimal> Cena_netto { get; set; }
        public int VAT { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        [Display(Name ="Cena Brutto")]
        [Required]
        public decimal Cena_brutto { get; set; }
        public string Opis { get; set; }
        [RegularExpression(@"[a-zA-Z0-9]{1,6}(\.)[a-z]{3}")]
        public string Obrazek { get; set; }

        public virtual Kategorie Kategorie { get; set; }
        public virtual Producenci Producenci { get; set; }
    }
}

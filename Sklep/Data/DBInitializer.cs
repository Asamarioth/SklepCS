using Microsoft.AspNetCore.Mvc.Routing;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Data
{
    public static class DBInitializer
    {
        public static void Initialize(SklepContext context)
        {

            if (context.Produkty.Any())
            {
                return;
                
            }

            var producenci = new Producenci[]
            {
                new Producenci{ Nazwa = "Acer" },
                new Producenci{Nazwa = "Logitech" },
                new Producenci{ Nazwa = "AOC" },
                new Producenci{ Nazwa = "Corsair" },
                new Producenci{Nazwa = "HyperX" },
            };
            context.Producenci.AddRange(producenci);
            context.SaveChanges();

            var kategorie = new Kategorie[]
            {
                new Kategorie { Nazwa = "Laptopy" },
                new Kategorie { Nazwa = "Klawiatury" },
                new Kategorie {  Nazwa = "Monitory" },
                new Kategorie { Nazwa = "Myszki" },
                new Kategorie { Nazwa = "Słuchawki" },
            };
            context.Kategorie.AddRange(kategorie);
            context.SaveChanges();

            var produkty = new Produkty[]
            {
                new Produkty{Id_kategorii =1,Id_producenta = 4,Nazwa="Słuchawki Corsair H550",Cena_netto=0,VAT=23,Cena_brutto=299.99m,Opis="Lorem ipsum doloret",Obrazek="1.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 2,Nazwa="Słuchawki Logitech G332",Cena_netto=0,VAT=23,Cena_brutto=219.00m,Opis="Lorem ipsum doloret",Obrazek="2.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 5,Nazwa="Słuchawki HyperX Cloud Stinger",Cena_netto=0,VAT=23,Cena_brutto=347.00m,Opis="Lorem ipsum doloret",Obrazek="3.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 5,Nazwa="Słuchawki HyperX Cloud II Gun",Cena_netto=0,VAT=23,Cena_brutto=344.99m,Opis="Lorem ipsum doloret",Obrazek="4.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 2,Nazwa="Mysz Logitech G102 Prodigy",Cena_netto=0,VAT=23,Cena_brutto=98.00m,Opis="Lorem ipsum doloret",Obrazek="5.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 4,Nazwa="Mysz Corsair M65 Pro RGB",Cena_netto=0,VAT=23,Cena_brutto=263.00m,Opis="Lorem ipsum doloret",Obrazek="6.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 2,Nazwa="Mysz HyperX Pulsefire Surge RGB",Cena_netto=0,VAT=23,Cena_brutto=189.00m,Opis="Lorem ipsum doloret",Obrazek="7.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 3,Nazwa="Monitor AOC C24G1",Cena_netto=0,VAT=23,Cena_brutto=949.00m,Opis="Lorem ipsum doloret",Obrazek="8.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 1,Nazwa="Monitor Acer Nitro XV273Xbmiiprzx",Cena_netto=0,VAT=23,Cena_brutto=1899.00m,Opis="Lorem ipsum doloret",Obrazek="9.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 3,Nazwa="Monitor AOC CQ32G1",Cena_netto=0,VAT=23,Cena_brutto=1599.00m,Opis="Lorem ipsum doloret",Obrazek="10.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 2,Nazwa="Klawiatura Logitech G213 Prodigy",Cena_netto=0,VAT=23,Cena_brutto=229.00m,Opis="Lorem ipsum doloret",Obrazek="11.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 5,Nazwa="Klawiatura HyperX Alloy Core RGB",Cena_netto=0,VAT=23,Cena_brutto=249.00m,Opis="Lorem ipsum doloret",Obrazek="12.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 4,Nazwa="Klawiatura Corsair K70 RGB MK.2 Rapidfire Low Profile",Cena_netto=0,VAT=23,Cena_brutto=679.00m,Opis="Lorem ipsum doloret",Obrazek="13.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 1,Nazwa="Laptop Acer Triton 5",Cena_netto=0,VAT=23,Cena_brutto=9399.00m,Opis="Lorem ipsum doloret",Obrazek="14.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 1,Nazwa="Laptop Acer Helios 300",Cena_netto=0,VAT=23,Cena_brutto=6999.00m,Opis="Lorem ipsum doloret",Obrazek="15.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 1,Nazwa="Laptop Acer Predator Helios 300",Cena_netto=0,VAT=23,Cena_brutto=6309.00m,Opis="Lorem ipsum doloret",Obrazek="16.jpg"}

            };
            context.Produkty.AddRange(produkty);
            context.SaveChanges();
        }
    }
}

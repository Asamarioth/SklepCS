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
            context.Database.EnsureCreated();

            if (context.Produkty.Any())
            {
                return;
                
            }

            var producenci = new Producenci[]
            {
                new Producenci{ Nazwa = "Producent_1" },
                new Producenci{Nazwa = "Producent_2" },
                new Producenci{ Nazwa = "Producent_3" },
                new Producenci{ Nazwa = "Producent_4" },
                new Producenci{Nazwa = "Producent_5" },
            };
            context.Producenci.AddRange(producenci);
            context.SaveChanges();

            var kategorie = new Kategorie[]
            {
                new Kategorie { Nazwa = "Kategoria_1" },
                new Kategorie { Nazwa = "Kategoria_2" },
                new Kategorie {  Nazwa = "Kategoria_3" },
                new Kategorie { Nazwa = "Kategoria_4" },
                new Kategorie { Nazwa = "Kategoria_5" },
            };
            context.Kategorie.AddRange(kategorie);
            context.SaveChanges();

            var produkty = new Produkty[]
            {
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_1_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="1"},
                new Produkty{Id_kategorii =1,Id_producenta = 2,Nazwa="Produkt_2_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="2"},
                new Produkty{Id_kategorii =2,Id_producenta = 3,Nazwa="Produkt_3_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="3"},
                new Produkty{Id_kategorii =2,Id_producenta = 4,Nazwa="Produkt_4_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="4"},
                new Produkty{Id_kategorii =3,Id_producenta = 5,Nazwa="Produkt_5_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="5"},
                new Produkty{Id_kategorii =3,Id_producenta = 1,Nazwa="Produkt_6_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="6"},
                new Produkty{Id_kategorii =4,Id_producenta = 2,Nazwa="Produkt_7_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="7"},
                new Produkty{Id_kategorii =4,Id_producenta = 3,Nazwa="Produkt_8_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="8"},
                new Produkty{Id_kategorii =5,Id_producenta = 4,Nazwa="Produkt_9_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="9"},
                new Produkty{Id_kategorii =5,Id_producenta = 5,Nazwa="Produkt_10_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="10"},
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_11_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="11"},
                new Produkty{Id_kategorii =2,Id_producenta = 2,Nazwa="Produkt_12_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="12"},
                new Produkty{Id_kategorii =3,Id_producenta = 3,Nazwa="Produkt_13_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="13"},
                new Produkty{Id_kategorii =4,Id_producenta = 4,Nazwa="Produkt_14_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="14"},
                new Produkty{Id_kategorii =5,Id_producenta = 5,Nazwa="Produkt_15_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="15"},
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_16_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Id_obrazek="16"}

            };
            context.Produkty.AddRange(produkty);
            context.SaveChanges();
        }
    }
}

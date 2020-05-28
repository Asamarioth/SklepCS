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
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_1_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="1.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 2,Nazwa="Produkt_2_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="2.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 3,Nazwa="Produkt_3_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="3.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 4,Nazwa="Produkt_4_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="4.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 5,Nazwa="Produkt_5_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="5.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 1,Nazwa="Produkt_6_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="6.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 2,Nazwa="Produkt_7_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="7.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 3,Nazwa="Produkt_8_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="8.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 4,Nazwa="Produkt_9_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="9.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 5,Nazwa="Produkt_10_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="10.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_11_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="11.jpg"},
                new Produkty{Id_kategorii =2,Id_producenta = 2,Nazwa="Produkt_12_2",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="12.jpg"},
                new Produkty{Id_kategorii =3,Id_producenta = 3,Nazwa="Produkt_13_3",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="13.jpg"},
                new Produkty{Id_kategorii =4,Id_producenta = 4,Nazwa="Produkt_14_4",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="14.jpg"},
                new Produkty{Id_kategorii =5,Id_producenta = 5,Nazwa="Produkt_15_5",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="15.jpg"},
                new Produkty{Id_kategorii =1,Id_producenta = 1,Nazwa="Produkt_16_1",Cena_netto=0,VAT=23,Cena_brutto=500,Opis="Lorem ipsum doloret",Obrazek="16.jpg"}

            };
            context.Produkty.AddRange(produkty);
            context.SaveChanges();
        }
    }
}

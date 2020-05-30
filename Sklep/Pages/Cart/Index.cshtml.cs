using Microsoft.AspNetCore.Mvc.RazorPages;
using Sklep.Helpers;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sklep.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly Sklep.Data.SklepContext _context;

        public IndexModel(Sklep.Data.SklepContext context)
        {
            _context = context;
        }

        public string Error { get; set; }
        public List<Item> Cart { get; set; }
        public decimal CartTotal { get; set; }

        public async Task OnGetAsync(int id, string action)
        {
            Error = "DEFAULT";
            Cart = new List<Item>();
            if (!String.IsNullOrEmpty(action))
            {
                switch (action)
                {
                    case "add":
                        if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
                        {
                            Cart = new List<Item>();
                            Cart.Add(new Item { Produkt = await _context.Produkty.FindAsync(id), Quantity = 1 });
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", Cart);
                        }
                        else
                        {
                            Cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                            int i = isExist(id);
                            if (i != -1)
                            {
                                Cart[i].Quantity++;
                            }
                            else
                            {
                                Cart.Add(new Item { Produkt = await _context.Produkty.FindAsync(id), Quantity = 1 });
                            }
                            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", Cart);
                        }
                        break;

                    case "addp":
                        Error = "addp";
                        Cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        int ip = isExist(id);
                        if (ip != -1)
                        {
                            Cart[ip].Quantity++;
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", Cart);
                        break;

                    case "addm":
                        Error = "addm";
                        Cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        int im = isExist(id);
                        if (im != -1)
                        {
                            if (Cart[im].Quantity != 1)
                                Cart[im].Quantity--;
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", Cart);
                        break;

                    case "remove":
                        Cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                        int index = isExist(id);
                        if (index != -1)
                        {
                            Cart.RemoveAt(index);
                        }
                        SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", Cart);
                        break;
                }

                
            }
            Cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if(Cart != null)
                CartTotal = Cart.Sum(item => item.Produkt.Cena_brutto * item.Quantity);
        }

        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Produkt.ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
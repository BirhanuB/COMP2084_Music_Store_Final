using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084_MusicStore.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId { get; set; }

        public ICollection<ShoppingCartLineItem> ShoppingCartLineItems { get; set; }

        public  void AddToCart(MusicStoreContext db, Song song)
        {

        }

        public static ShoppingCart GetUserCart(HttpContext http)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartId = cart.GetCartId(http);
            return cart;
        }

        public string GetCartId(HttpContext http)
        {
            if (http.Session.GetString("CartId") == null)
            {
                if (!string.IsNullOrWhiteSpace(http.User.Identity.Name))
                {
                    http.Session.SetString("CartId", http.User.Identity.Name);
                }
            }

            return http.Session.GetString("CartId");
        }
    }
}

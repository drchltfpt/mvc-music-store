using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        // List items choosed
        public List<Cart> CartItems { get; set; }

        // 
        public decimal CartTotal { get; set; }
    }
}
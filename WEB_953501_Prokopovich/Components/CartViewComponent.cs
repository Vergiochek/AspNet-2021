using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953501_Prokopovich.Extensions;
using WEB_953501_Prokopovich.Models;

namespace WEB_953501_Prokopovich.Components
{
    public class CartViewComponent : ViewComponent
    {

        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}

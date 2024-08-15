//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*
         public ViewResult Index()
         {
             Product?[] products = Product.GetProducts();
             return View(new string[] { 
                 $"Name: {products[0]?.Name}, Price: {products[0]?.Price}"
             });
        */

        /*
        public ViewResult Index()
        {
            Dictionary<string, Product> products = new()
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product { Name = "LifeJacket", Price = 48.95M }
            };
            return View("Index", products.Keys);
        }
        */
        /*
        public ViewResult Index()
        {
            object[] data = new object[] {275M, 29.95M, "apple",
                             "orange",100, 10};
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d) { total += d; }
            }
            return View("Index", new string[] {$"Total: {total:C2}"});
        }
        */
        /*
        public ViewResult Index()
        {
            object[] data = new object[] {275M, 29.95M, "apple",
                             "orange",100, 10};
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue; break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }
        */

        //bool FilterByPrice(Product? p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        /*
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts()};

            Product[] productArray =
            {
                new Product{Name="Kayak",Price=275M},
                new Product{Name="Lifejacket", Price=48.95M},
                new Product{Name="Soccer ball", Price=19.50M},
                new Product{Name="Corner Flag", Price=34.95M}
            };

            //Func<Product?, bool> nameFilter = delegate (Product? prod)
            //{
             //   return prod?.Name?[0] == 'S';
           // };

            //decimal cartTotal = cart.TotalPrices();
            decimal priceFilterTotal = productArray.
                                       Filter(p => (p?.Price??0) >=20).TotalPrices();
            decimal nameFilterTotal = productArray
                                      .Filter(p => p?.Name?[0] == 'S').TotalPrices();

            return View("Index", new string[]
            {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}"
            });
            
        }
        */
         
        /*
        public ViewResult Index()
        {
            IProductSelection cart = new ShoppingCart(
                new Product {Name="Kayak", Price=275M},
                new Product {Name="Lifejacket", Price=48.95M},
                new Product {Name="Soccer ball", Price=19.50M},
                new Product {Name="Corner flag", Price=34.95M} );
            return View(cart.Names);
        }
      */
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }

    }
}

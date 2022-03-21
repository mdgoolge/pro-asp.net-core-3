using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    List<string> results = new List<string>();
        //    foreach (Product p in Product.GetProducts())
        //    {
        //        //string name = p?.Name;
        //        //decimal? price = p?.Price;
        //        //string relatedName = p?.Related?.Name;
        //        string name = p?.Name ?? "<No Name>";
        //        decimal? price = p?.Price ?? 0;
        //        string relatedName = p?.Related?.Name ?? "<None>";
        //        //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
        //        results.Add($"Name: {name}, Price: {price:C2}, Related: {relatedName}");
        //    }
        //    return View(results);
        //}
        //public ViewResult Index()
        //{
        //    string[] names = new string[3];
        //    names[0] = "Bob";
        //    names[1] = "Joe";
        //    names[2] = "Alice";
        //    return View("Index", names);
        //}

        //public ViewResult Index()
        //{
        //    return View("Index", new string[] { "Bob", "Joe", "Alice" });
        //}

        //        public ViewResult Index()
        //        {
        //            Dictionary<string, Product> products = new Dictionary<string, Product> {
        //{ "Kayak", new Product { Name = "Kayak", Price = 275M } },
        //{ "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
        //};
        //            return View("Index", products.Keys);
        //        }

        //public ViewResult Index()
        //{
        //    Dictionary<string, Product> products = new Dictionary<string, Product>
        //    {
        //        ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //        ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //    };
        //    return View("Index", products.Keys);
        //}

        //public ViewResult Index()
        //        {
        //            object[] data = new object[] { 275M, 29.95M,
        //"apple", "orange", 100, 10 };
        //            decimal total = 0;
        //            for (int i = 0; i < data.Length; i++)
        //            {
        //                if (data[i] is decimal d)
        //                {
        //                    total += d;
        //                }
        //            }
        //            return View("Index", new string[] { $"Total: {total:C2}" });
        //        }

        //        public ViewResult Index()
        //        {
        //            object[] data = new object[] { 275M, 29.95M,
        //"apple", "orange", 100, 10 };
        //            decimal total = 0;
        //            for (int i = 0; i < data.Length; i++)
        //            {
        //                switch (data[i])
        //                {
        //                    case decimal decimalValue:
        //                        total += decimalValue;
        //                        break;
        //                    case int intValue when intValue > 50:
        //                        total += intValue;
        //                        break;
        //                }
        //            }
        //            return View("Index", new string[] { $"Total: {total:C2}" });
        //        }

        //public ViewResult Index()
        //{
        //    ShoppingCart cart
        //    = new ShoppingCart { Products = Product.GetProducts() };
        //    decimal cartTotal = cart.TotalPrices();
        //    return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        //}

        //        public ViewResult Index()
        //        {
        //            ShoppingCart cart
        //            = new ShoppingCart { Products = Product.GetProducts() };
        //            Product[] productArray = {
        //new Product {Name = "Kayak", Price = 275M},
        //new Product {Name = "Lifejacket", Price = 48.95M}
        //};
        //            decimal cartTotal = cart.TotalPrices();
        //            decimal arrayTotal = productArray.TotalPrices();
        //            return View("Index", new string[] {
        //$"Cart Total: {cartTotal:C2}",
        //$"Array Total: {arrayTotal:C2}" });
        //        }

        //        public ViewResult Index()
        //        {
        //            Product[] productArray = {
        //new Product {Name = "Kayak", Price = 275M},
        //new Product {Name = "Lifejacket", Price = 48.95M},
        //new Product {Name = "Soccer ball", Price = 19.50M},
        //new Product {Name = "Corner flag", Price = 34.95M}
        //};
        //            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        //            return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
        //        }

        //        public ViewResult Index()
        //        {
        //            Product[] productArray = {
        //new Product {Name = "Kayak", Price = 275M},
        //new Product {Name = "Lifejacket", Price = 48.95M},
        //new Product {Name = "Soccer ball", Price = 19.50M},
        //new Product {Name = "Corner flag", Price = 34.95M}
        //};
        //            decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
        //            decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
        //            return View("Index", new string[] {
        //$"Price Total: {priceFilterTotal:C2}",
        //$"Name Total: {nameFilterTotal:C2}" });
        //        }
        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        //public ViewResult Index()
        //{
        //    Product[] productArray = {
        //new Product {Name = "Kayak", Price = 275M},
        //new Product {Name = "Lifejacket", Price = 48.95M},
        //new Product {Name = "Soccer ball", Price = 19.50M},
        //new Product {Name = "Corner flag", Price = 34.95M}
        //};
        //    Func<Product, bool> nameFilter = delegate (Product prod) {
        //        return prod?.Name?[0] == 'S';
        //    };
        //    decimal priceFilterTotal = productArray
        //    .Filter(FilterByPrice)
        //    .TotalPrices();
        //    decimal nameFilterTotal = productArray
        //    .Filter(nameFilter)
        //    .TotalPrices();
        //    return View("Index", new string[] {
        //$"Price Total: {priceFilterTotal:C2}",
        //$"Name Total: {nameFilterTotal:C2}" });
        //}

        //        public ViewResult Index()
        //        {
        //            Product[] productArray = {
        //new Product {Name = "Kayak", Price = 275M},
        //new Product {Name = "Lifejacket", Price = 48.95M},
        //new Product {Name = "Soccer ball", Price = 19.50M},
        //new Product {Name = "Corner flag", Price = 34.95M}
        //};
        //            decimal priceFilterTotal = productArray
        //            .Filter(p => (p?.Price ?? 0) >= 20)
        //            .TotalPrices();
        //            decimal nameFilterTotal = productArray
        //            .Filter(p => p?.Name?[0] == 'S')
        //            .TotalPrices();
        //            return View("Index", new string[] {
        //$"Price Total: {priceFilterTotal:C2}",
        //$"Name Total: {nameFilterTotal:C2}" });
        //        }
        //public ViewResult Index()
        //{
        //    return View(Product.GetProducts().Select(p => p?.Name));
        //}
        //        public ViewResult Index() =>
        //View(Product.GetProducts().Select(p => p?.Name));
        //    }

        //public ViewResult Index()
        //{
        //    var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
        //    return View(names);
        //}

        //        public ViewResult Index()
        //        {
        //            var products = new[] {
        //new { Name = "Kayak", Price = 275M },
        //new { Name = "Lifejacket", Price = 48.95M },
        //new { Name = "Soccer ball", Price = 19.50M },
        //new { Name = "Corner flag", Price = 34.95M }
        //};
        //            //return View(products.Select(p => p.Name));
        //            return View(products.Select(p => p.GetType().Name));
        //        }

        //public ViewResult Index()
        //{
        //    IProductSelection cart = new ShoppingCart(
        //    new Product { Name = "Kayak", Price = 275M },
        //    new Product { Name = "Lifejacket", Price = 48.95M },
        //    new Product { Name = "Soccer ball", Price = 19.50M },
        //    new Product { Name = "Corner flag", Price = 34.95M }
        //    );
        //    //return View(cart.Products.Select(p => p.Name));
        //    return View(cart.Names);
        //}   

        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}

        //public async Task<ViewResult> Index()
        //{
        //    List<string> output = new List<string>();
        //    foreach (long? len in await MyAsyncMethods.GetPageLengths(output,
        //    "apress.com", "microsoft.com", "amazon.com"))
        //    {
        //        output.Add($"Page length: { len}");
        //    }
        //    return View(output);
        //}

        //public async Task<ViewResult> Index()
        //{
        //    List<string> output = new List<string>();
        //    await foreach (long? len in MyAsyncMethods.GetPageLengths(output,
        //    "apress.com", "microsoft.com", "amazon.com"))
        //    {
        //        output.Add($"Page length: { len}");
        //    }
        //    return View(output);
        //}

//        public ViewResult Index()
//        {
//            var products = new[] {
//new { Name = "Kayak", Price = 275M },
//new { Name = "Lifejacket", Price = 48.95M },
//new { Name = "Soccer ball", Price = 19.50M },
//new { Name = "Corner flag", Price = 34.95M }
//};
//            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
//        }

        public ViewResult Index()
        {
            var products = new[] {
new { Name = "Kayak", Price = 275M },
new { Name = "Lifejacket", Price = 48.95M },
new { Name = "Soccer ball", Price = 19.50M },
new { Name = "Corner flag", Price = 34.95M }
};
            return View(products.Select(p =>
            $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}

    
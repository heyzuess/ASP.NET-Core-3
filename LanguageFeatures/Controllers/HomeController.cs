using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        bool FilterByPrice(Product p)
        {
            return (p?.Price ?? 0) >= 20;
        }

        public async  Task<ViewResult> Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 3334.95M }
            };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));

            /*
            List<string> output = new List<string>();

            await foreach (long? len in MyAsyncMethods
                .GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {len}");
            }

            return View(output);
            */

            /*
            long? length = await MyAsyncMethods.GetPageLength();

            return View(new string[] { $"Length: {length}" });
            */

            /*
            IProductSelection products = new ShoppingCart(
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M},
                new Product { Name = "Soccer ball", Price = 19.50M},
                new Product { Name = "Corner Flag", Price = 34.95M}
            );

            return View(products.Names);
            */

            /*
            var names = new[] { "Kayak", "LifeJacket", "Soccer ball" };
            return View(names);
            */

            //return View(Product.GetProducts().Select(p => p?.Name ?? "<No Name>"));

            /*
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }

            return View(results);
            */

            /*
            Dictionary<string, Product> products = new Dictionary<string, Product> {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["LifeJacket"] = new Product { Name = "LifeJacket", Price = 48.95M }
            };

            return View("Index", products.Keys); 
            */

            /*
            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;
            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }*/

            /*
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }

            return View("Index", new string[] { $"Total: {total:C2}" });
            */

            /*
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            decimal cartTotal = cart.TotalPrices();

            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
            */

            /*
            Product[] productArray =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 39.95M }
            };

            Func<Product, bool> nameFilter = delegate (Product prod)
            {
                return prod?.Name?[0] == 'S';
            };

            decimal arrayTotal = productArray
                .Filter(p => (p?.Price ?? 0) >= 20)
                .TotalPrices();

            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'S')
                .TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}",
                $"Name Total: {nameFilterTotal}"
            });
            */
        }
    }
}

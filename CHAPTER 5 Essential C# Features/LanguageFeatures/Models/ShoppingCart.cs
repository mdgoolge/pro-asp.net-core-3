using System.Collections.Generic;
using System.Collections;
namespace LanguageFeatures.Models
{
    //public class ShoppingCart
    //{
    //    public IEnumerable<Product> Products { get; set; }
    //}

    //public class ShoppingCart : IEnumerable<Product>
    //{
    //    public IEnumerable<Product> Products { get; set; }
    //    public IEnumerator<Product> GetEnumerator()
    //    {
    //        return Products.GetEnumerator();
    //    }
    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}

    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new List<Product>();
        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product> Products { get => products; }
    }
}
    
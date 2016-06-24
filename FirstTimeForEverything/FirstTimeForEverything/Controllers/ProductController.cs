using FirstTimeForEverything.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace FirstTimeForEverything.Controllers
{
    public class ProductController : ApiController
    {
        Product[] productsForSale = new Product[]
        {
            new Product {ID = 1, Name = "Chicken Noodle Soup", Category = "Groceries", Price = 1 },
            new Product {ID = 2, Name = "Hot Wheels Cars", Category = "Toys", Price = 2.50m },
            new Product {ID = 3, Name = "Hammer", Category = "Hardware", Price = 19.99m }
        };

        //this method returns an entire list of the products based as the IEnumerable<Product> type... pretty cool w the IEnumerable
        public IEnumerable<Product> GetAllProducts()
        {
            return productsForSale;
        }

        //this method looks up a single product based on the ID. 
        public IHttpActionResult GetProduct(int id)
        {
            var product = productsForSale.FirstOrDefault((p) => p.ID == id);
            if (product == null)
            {
                return NotFound(); 
            }
            return Ok(product); 
        }
    }
}
//now, we have a working URI... GetAllProducts URI will be /api/products and the GetProduct will be /api/product/ID. 
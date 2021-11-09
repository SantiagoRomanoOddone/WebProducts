using System;
using System.Collections.Generic;
using System.Data.Entity;//a
using System.Linq;
using System.Web;
using WebProducts.Models;//a

namespace WebProducts.Data
{
    public class ProductsInitializer : DropCreateDatabaseAlways<ProductDbContext>
    {
        protected override void Seed(ProductDbContext context)
        {
            var products = new List<Product>
            {
               new Product {

                    Category ="Electronics" ,
                    ProductName = "Sony",
                    Description = "46º TV",
                    AvailableDate = Convert.ToDateTime("1/1/2012") ,
                }
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
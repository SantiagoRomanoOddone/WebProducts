using System;
using System.Collections.Generic;
using System.Data.Entity;//a
using System.Linq;
using System.Web;
using WebProducts.Models;//a

namespace WebProducts.Data
{
    //Argreg DbContext
    public class ProductDbContext: DbContext
    {
        public ProductDbContext() : base("KeyDB") { }
        public DbSet<Product>Products { get; set; }
    }
}
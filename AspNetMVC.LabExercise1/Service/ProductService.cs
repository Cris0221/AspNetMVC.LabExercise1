using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Service
{
   
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Samsung Galaxy S9",
                Description = "large screen",
                Quantity = 2,
                Price = 20_000M
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Samsung Galaxy S10",
                Description = "better performance",
                Quantity = 5,
                Price = 27_000M
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Samsung Galaxy S20",
                Description = "Responsive",
                Quantity = 12,
                Price = 31_000M
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Samsung Galaxy S21",
                Description = "no lag issues",
                Quantity = 1,
                Price = 50_000M
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Samsung Galaxy S22",
                Description = "camera is superb",
                Quantity = 7,
                Price = 62_000M
            });
        }
        public List<Product> GetCatalog() { return products; }
        public decimal GetGrandtotal()
        {
            decimal grandTotal = 0;
            foreach (Product product in products)
            {
                grandTotal += product.TotalAmount;
            }
            return grandTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryID = 1, Name = "PC"},
                new Category{CategoryID = 2, Name = "Telefon"}
            };
            
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,CategoryID = 1, Name = "Asus Laptop", QantityPerUnit = "64 GB RAM",UnitPrice = 16000, UnitsInStock = 61 },
                new Product{Id=2,CategoryID = 1, Name = "lENOVA Laptop", QantityPerUnit = "32 GB RAM",UnitPrice = 10000, UnitsInStock = 15 },
                new Product{Id=3,CategoryID = 2, Name = "Samsun A52", QantityPerUnit = "64 GB RAM",UnitPrice = 14000, UnitsInStock = 61 },
                new Product{Id=4,CategoryID = 2, Name = "IOS 14", QantityPerUnit = "32 GB RAM",UnitPrice = 1000, UnitsInStock = 15 },
            };
            Console.WriteLine(GetProducts(products)[0].Name);
            foreach (Product product in GetProducts(products))
                Console.WriteLine(product.Name);
            Console.ReadLine();
            
        }
        static List<Product> GetProducts(List<Product> products)
        {
            var result = products.Where(product => product.CategoryID == 1 && product.UnitPrice >= 10000  ).ToList();
            return result;
        }
    }
    class Product
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string QantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

    }
}

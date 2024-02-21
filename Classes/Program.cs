using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManeger = new CustomerManager();
            customerManeger.Add();
            customerManeger.Remove();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();

            Customer customer = new Customer();
            customer.Id = 61;
            customer.FirstName = "anıl";
            customer.LastName = "bahram";
            customer.City = "Trabzon";
            
            //Üsteki kullanımla bu kullanım aynı
            Customer customer1 = new Customer
            {
                City = "ankara",
                FirstName = "canan",
                LastName = "bahram",
                Id = 06
            };

            //bu şekide kullanabilmek için consructor oluşturulmalı
            Customer customer2 = new Customer(12, "kamil", "bahram", "istanbul");

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}

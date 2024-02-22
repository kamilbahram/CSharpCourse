using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person(){FirstName="kamil"},
                new Customer(){FirstName="anıl"},
                new Student(){FirstName= "atalay"}
            };
            foreach (Person person in persons)
                Console.WriteLine(person.FirstName);

            // Referans çalışması
            Person person1 = new Person();
            Student student1 = new Student() { ID = 1, FirstName = "kamil", LastName = "bahram" };
            student1.StudentNuber = 4;
            person1 = student1;  // student1 in referans gözterdiği hafızada person1 değerlerini kayıt edebilir.
            
            // student1 = person1; bu şeklde eşitleme uygun olmaz
            student1 = person1 as Student; // burdaki çalışma bicimini sorgula
            Console.WriteLine(person1.ID + ": " + person1.FirstName);
            Console.ReadLine();
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Person
    {
        public int StudentNuber { get; set; }

    }
    class Customer : Person
    {

    }
}

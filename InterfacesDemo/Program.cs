using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //interface planlanlama solId
            // interface segregation

            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Robot(),
                new Worker()
            };
            IEat[] eats = new IEat[]
{
                new Manager(),
                new Worker()
};
            IGetSalary[] getSalaries = new IGetSalary[]
            {
                new Manager(),
                new Worker()
            };

            foreach (IWorker worker in workers)
            {
                worker.Work();
            }

            foreach(IGetSalary getSalary in getSalaries)
            {
                getSalary.GetSalary();
            }

            foreach(IEat eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
                
        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine( "maneger eat...");
        }

        public void GetSalary()
        {
            Console.WriteLine("manager get salary...");
        }

        public void Work()
        {
            Console.WriteLine("manager work...");
        }
    }
    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("worker eat...");
        }

        public void GetSalary()
        {
            Console.WriteLine("worker get salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker work...");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("robot work...");
        }
    }
}

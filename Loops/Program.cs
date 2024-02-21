using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("çift sayılar");
            for (int i = 0; i < 61; i += 2) { Console.WriteLine(i); }
            Console.WriteLine("Tek sayılar");
            for (int i = 61; i > 0; i -= 2) { Console.WriteLine(i); }  // karşılaştır işlem yap sayacı azalt

            int number = 61;
            while (number > 0) { Console.WriteLine(number); number--; }
            Console.WriteLine("do while");
            number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }while (number > 0);

            Console.WriteLine("Foreach");
            string[] students2 = new[] { "zlatan", "ibrahim", "ovic", "Yattara" };
            foreach (string student in students2) { Console.WriteLine(student); }   
            Console.ReadLine();
        }

    }
}

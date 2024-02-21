using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("methods");
            //int a = 20;
            //int b = 30;
            //var k = Add3(a, a, b);
            //Console.WriteLine(k);
            //Add();
            //Add();
            //Add2(34, 54);
            //Add3(3);
            //Add3(45, 56, 78);
            //Add4(out a, b);
            //var result = Add3(61, 34);
            //Console.WriteLine(result);
            
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(3,4,9));
            Console.WriteLine(Add4(1,2,3,4,5));

            Console.ReadLine();
        }
        static void Add() { Console.WriteLine("addd"); }
        static int Add2(int a, int b) { return a + b; }
        static int Add3(int a, int b = 46, int c = 56)
        {
            a = 3;
            return a + b + c;
        }
        static int Add4(out int a, int b)
        {
            a = 24;
            return a + b;
        }

        //method overloading
        static int Multiply(int number1, int number2) { return number1 * number2; }
        static int Multiply(int number1, int number2, int number3) { return number1 * number2 * number3; }

        static int Add4(params int [] numbers) { return numbers.Sum(); }
        
    }
}

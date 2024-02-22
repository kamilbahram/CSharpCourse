using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba veri tipleri alıştırmasına hoş geldiniz!!!");

            int number = 61; //max dokuz basamaklı değer tanımlanabilir.
            long longNumber = 2378888888888788888; // max 19 basamak ondalıklı değer atanamaz. 
            double doububleNumber = 7845455484545454444; // max 19 basmaklı değer tanımlnabilir.
            double doubleleNumber2 = 2424.3;
            decimal decimalNumber = 2344423322234234234234322323M; //max 29 basamak ve ondalıklı değer tanımlanabilir
            decimal decimalNumber2 = 2342342234444.245445455M;
            char character = 'a';
            bool condition = false;
            byte number1 = 255;  // max 255 değeri atanır 
            var numberX = 678;

            Console.WriteLine("number : " + number);
            Console.WriteLine("longNumber : {0}  doubleNumber {1}", longNumber, doubleleNumber2);
            Console.WriteLine("char : {0} bool {1} byte {2}", character, condition, number1);
            Console.WriteLine("matematiksel işlem yapmaz : " + numberX + number);
            Console.WriteLine(numberX + number);
            Console.WriteLine(Days.Friday);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Friday, Saturday, Sunday
    }
}

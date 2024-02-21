using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stringler char array dir.
            //NewMethod();
            string sentence = "my name is kamil bahram";

            var result = sentence.Length;
            var result1 = sentence.Clone();
            sentence = "sdfdsf";

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(sentence);

            bool result2 = sentence.EndsWith("k");
            bool result3 = sentence.StartsWith("m");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, " hello ");
            var result9 = sentence.Substring(0, 3);
            var result10 = sentence.ToLower();
            var result11 = sentence.Replace("kamil", "armut");
            var result13 = sentence.Remove(0, 3);   

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string str = "kamil";
            string str2 = "anıl";
            foreach (var sr in str)
            {
                Console.WriteLine(sr);
            }
            Console.WriteLine(string.Format("{0}{1}", str, str2));
            Console.WriteLine(str + str2);
        }
    }
}

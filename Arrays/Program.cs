using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            string[] students1 = new string[4];
            students1[0] = "Anıl";
            students1[1] = "kamil";
            students1[2] = "Ayça";
            students1[3] = "Gökçe";
            string[] students2 = new[] { "zlatan", "ibrahim", "ovic", "Yattara" };
            string[] students3 = { "xyz", "mahmut" };
            string[][] students4 = { students1, students2, students3 };

            string[,] regions = new string[5, 3];

            string[,] regions2 = new string[3, 2] { { "abc", "def" }, { "kml", "dvff" }, { "smfer", "dgre" } };

            foreach (string[] students in students4)
            {
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine("çok boyutlulu kullanım şekli 2");
            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                    Console.WriteLine(regions2[i, j]);
            Console.ReadLine();
        }
    }
}

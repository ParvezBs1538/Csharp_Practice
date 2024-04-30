using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // number input
            Console.Write("Enter a number input : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            // array input
            Console.Write("Enter Array input : ");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // string input
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }
    }
}

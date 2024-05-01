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
            int[] a = new int[] { 1, 2, 3, 1};
            int ind = Array.IndexOf(a, 1);
            int ind1 = Array.LastIndexOf(a, 1);
            Console.WriteLine($"{ind} {ind1}");

            string s = "Parvez";
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.IndexOf('a')); // first index of a
            Console.WriteLine(s.Substring(1)); // startIndex
            Console.WriteLine(s.Substring(1, 3)); // startIndex, Length

            string ss = s.Replace("par", "Masud"); // replace method
            Console.WriteLine(ss);
        }
    }
}

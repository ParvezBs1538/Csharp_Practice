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
            Dictionary<int, string> mp = new Dictionary<int, string>();
            mp.Add(2, "Two");
            mp.Add(1, "One");
            mp.Add(3, "Three");

            foreach (var item in mp)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            // assending order sort ordery by key
            var sortAsc = mp.OrderBy(x => x.Key);
            foreach (var item in sortAsc)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine();

            // descending order sort ordery by key
            var sortDsc = mp.OrderByDescending(x => x.Key);
            foreach (var item in sortDsc)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}

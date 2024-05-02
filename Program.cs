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
            HashSet<int> set = new HashSet<int>() { 1, 3, 3};

            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };

            set.IntersectWith(set1);
            set.UnionWith(set1);

            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}

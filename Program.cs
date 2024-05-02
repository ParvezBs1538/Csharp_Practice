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
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);

            var first = list.First;
            list.AddAfter(first, 5);
            list.AddBefore(first, 6);

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            var node = list.First;
            while(node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }
        }
    }
}

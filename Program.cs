using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    internal class Program
    {
        internal class GenCls<T>
        {
            public void GetData(T data) 
            {
                Console.WriteLine(data);
            }
        }
        static void Main(string[] args)
        {
            GenCls<string> genString = new GenCls<string>();
            genString.GetData("Hello World");

            GenCls<int> genInt = new GenCls<int>();
            genInt.GetData(35);
        }
    }
}
// A generic class is a class that can work with any data type
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    internal class Program
    {
        public enum Status
        {

            ongoing,
            delivery,
            payment
        }
        static void Main(string[] args)
        {
            var x = Status.ongoing;
            Console.WriteLine((int)Status.payment);
            Console.WriteLine((Status)1);
            Console.WriteLine(x.ToString());
        }
    }
}

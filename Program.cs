using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    public delegate void Calculator(int a, int b);
    class Program
    {
        public void Addition(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine($"Addition result is : {ans}"); ;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //Calculator obj = new Calculator(Program.Addition);
            Calculator obj = program.Addition;
            obj.Invoke(20, 10);
            program.Addition(20, 10);
        }
    }
}
// when we dosen't use static method then you should be create program class object
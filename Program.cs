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
        public static void Addition(int a, int b)
        {
            int ans = a + b;
            Console.WriteLine($"Addition result is : {ans}"); ;
        }
        public static void Subtraction(int a, int b)
        {
            int ans = a - b;
            Console.WriteLine($"Subtraction result is : {ans}"); ;
        }
        public static void Multiplication(int a, int b)
        {
            int ans = a * b;
            Console.WriteLine($"Multiplication result is : {ans}"); ;
        }
        public static void Division(int a, int b)
        {
            int ans = a / b;
            Console.WriteLine($"Division result is : {ans}"); ;
        }
        static void Main(string[] args)
        {
            //Calculator obj = new Calculator(Program.Addition);
            Calculator obj = Program.Addition;
            obj.Invoke(20, 10);
            //Program.Addition(20, 10);
            obj = Subtraction;
            obj(20, 10);

            obj = Multiplication;
            obj(20, 10);

            obj = Division;
            obj.Invoke(20, 10);
        }
    }
}

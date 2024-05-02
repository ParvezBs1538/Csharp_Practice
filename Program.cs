using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string RegNo { get; set; }
    }
    internal class Program
    {
        public delegate int CalculatorHandler(int num1, int num2);
        static void Main(string[] args)
        {
            Student student = new Student();
            CalculatorHandler calculatorHandler = Add;
            //CalculatorHandler calculatorHandler = new CalculatorHandler(Add);

            //int result = calculatorHandler.Invoke(12, 40);
            int result = calculatorHandler(12, 40);
            Console.WriteLine(result);
        }
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}

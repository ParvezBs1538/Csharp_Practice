namespace PracticeAPp
{
    internal class Program
    {
        public class Person
        {
            public string firstName;
            public string lastName;
            public void fullName()
            {
                Console.WriteLine($"My name is {firstName} {lastName}");
            }
        }
        public class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Sub(int a, int b)
            {
                return a - b;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator();
            int sum = calculate.Add(15, 12);
            int sub = calculate.Sub(15, 12);
            Console.WriteLine($"Sum = {sum} & Sub = {sub}");

            Person person1 = new Person();
            person1.firstName = "Masud";
            person1.lastName = "Parvez";
            person1.fullName();
        }
    }
}

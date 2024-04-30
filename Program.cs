namespace PracticeAPp
{
    internal class Program
    {
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

namespace PracticeAPp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string to int
            string s = "123";
            int x = int.Parse(s);
            Console.WriteLine(x);

            // int to string
            int num = 123;
            string ss = num.ToString();
            Console.WriteLine(ss);

            //float to int
            float f = 3.5f;
            int y = (int)f;
            Console.WriteLine(y);

        }
    }
}

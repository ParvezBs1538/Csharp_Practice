using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAPp
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public static class Extension
    {
        public static string GetInfo(this Student Student) // first parameter include this keyword
        {
            return "ID: " + Student.Id + " Name: " + Student.Name + " Address: " + Student.Address;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Student = new Student();
            Student.Id = 101;
            Student.Name = "Parvez";
            Student.Address = "Mirpur";

            string info = Student.GetInfo();
            Console.WriteLine(info);
        }
    }
}

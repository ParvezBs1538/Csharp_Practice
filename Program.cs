using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    public interface IDrawable
    {
        void draw();
    }
    public class Rectangle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle.");
        }
    }
    public class Circle : IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable obj;
            obj = new Rectangle();
            obj.draw();

            obj = new Circle();
            obj.draw();
        }
    }
}

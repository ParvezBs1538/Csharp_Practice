using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace PracticeAPp
{
    class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = new object[] { 2, 1, 3, 5, 4 };
            object[] arr = new object[] {"par", "vez", "abc", "saif"};
            SortArray obj = new SortArray();
            obj.BubbleSort(arr);
            foreach (var it in arr)
                Console.Write(it + " ");
        }
    }
    public class SortArray
    {
        public void BubbleSort(object[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j+1]) > 0)
                    {
                        Swap(arr, j);
                    }
                }
            }
        }
        private void Swap(object[] arr, int i)
        {
            object tmp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = tmp;
        }
    }
}

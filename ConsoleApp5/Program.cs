using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 24, 5, 3, 2, 24, 78, 9, 16, 3,10,21,21 };
            List<int> ls = uniqueArr(arr);
            Console.WriteLine("уникальные числа исходного массива:");
            foreach(var i in ls)
            {
                Console.Write(i+ " ");
                
            }
            Console.ReadLine();
            

        }
       static List<int> uniqueArr(int[] arr)
        {
            List<int> ls = new List<int>();

            foreach(int i in arr)
            {
                if (!ls.Contains(i))
                {
                    ls.Add(i);
                }
                else
                {
                    ls.Remove(i);
                }
            }
            return ls;
        }
    }
}

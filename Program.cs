using System;
using System.Collections.Generic;

namespace code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>();
            nums.Add(1);
            nums.Add(9);
            nums.Add(0);
            nums.Add(7);
            nums.Add(4);
            nums.Add(3);
            nums.Add(8);
            nums.Add(2);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"How much numbers: { nums.Count}");
            /*метод видалення "вручну"*/
            //nums.Insert(0, 9);
            //nums.RemoveAt(2);
            //nums.Insert(2, 7);
            //nums.RemoveAt(4);
            //nums.Insert(4, 3);
            //nums.RemoveAt(6);
            //nums.Insert(6, 2);
            //nums.RemoveAt(8);
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == 0)
                {
                    nums.Insert(i, nums[1]);
                    nums.RemoveAt(2);
                }
                if (i != 0 && i % 2 == 0 && i < nums.Count)
                {
                    
                    nums.Insert(i, nums[i+1]);                    
                    nums.RemoveAt(i+2);
                }
            }
            foreach (var num1 in nums)
            {
                Console.Write(num1 + " ");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(25, 75);
            }
            int search;
            for (int i = 0; i < nums.Length; i++)
            {
                search = i;
                int sum = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[search])
                    {
                        sum++;
                    }
                }
                Console.WriteLine("Number " + nums[search] + " repeated " + sum + " Times");
            }
            recursive(0, nums, 0);
        }
        static void recursive(int n, int[] nums, int num)
        {
            if (n == nums.Length) { return; }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[n])
                {
                    num++;
                }
            }
            Console.WriteLine(nums[n] + "REPEAT:" + num);
            recursive(n+1, nums, 0);


        }
    }
}

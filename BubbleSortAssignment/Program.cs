using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, -2, -3, 2, 5, 1 };

            Sort(input);

            Console.ReadLine();
        }

        private static void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if(input[j] > input[j + 1])
                    {
                        int num = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = num;
                    }
                }
            }

            foreach (int num in input)
            {
                Console.WriteLine(num);
            }
        }
    }
}

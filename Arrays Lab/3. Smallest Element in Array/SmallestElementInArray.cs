using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SmallestElementInArray
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int smallest = int.MaxValue;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]<smallest)
            {
                smallest = input[i];
            }
        }
        Console.WriteLine(smallest);
    }
}


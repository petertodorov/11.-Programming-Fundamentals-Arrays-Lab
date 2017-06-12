using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class oddNumbersAtOddPositions
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
 
        for (int i = 0; i < input.Length; i++)
        {
            if (i%2!=0)
            {
                if (input[i] % 2 != 0)
                {
                    Console.WriteLine($"{i} -> {input[i]}");
                }
            }
        }
    }
}


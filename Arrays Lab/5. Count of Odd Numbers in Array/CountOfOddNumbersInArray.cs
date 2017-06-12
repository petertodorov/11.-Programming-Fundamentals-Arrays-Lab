using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CountOfOddNumbersInArray
    {
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 0;
        counter = CountOddElements(input, counter);
        Console.WriteLine(counter);
    }

    private static int CountOddElements(int[] input, int counter)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (Math.Abs(input[i]) % 2 == 1)
            {
                counter++;
            }
        }
        return counter;
    }
}


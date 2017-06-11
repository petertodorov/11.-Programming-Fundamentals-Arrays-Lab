using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SumArrayElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] input = new int[n];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        sum = input.Sum();
        Console.WriteLine(sum);
    }
}





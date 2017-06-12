using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RotateArrayOfStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        string[] result = new string[input.Length];
        string last = input[input.Length - 1];
        result[0] = last;
        for (int i = 1; i < input.Length; i++)
        {
            result[i] = input[i-1];
        }



        Console.WriteLine(String.Join(" ",result));
    }
}


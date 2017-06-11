using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplyAnArrayOfDoubles
{
    static void Main(string[] args)
    {
        double p = double.Parse(Console.ReadLine());
        double[] input = new double[] { 1.2, 3.0, 12.3, 4.56 };
        for (int i = 0; i < input.Length; i++)
        {
            input[i] *= p;
            Console.Write(input[i]+" ");
        }
    }
}


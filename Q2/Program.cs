using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int nextNumber, sum=0;
            if (firstNumber % 2 == 0)
                sum = firstNumber;
            if (secondNumber % 2 == 0)
                sum = secondNumber;
            while (secondNumber <= 4_000_000)
            {
                nextNumber = firstNumber + secondNumber;
                if (nextNumber % 2 == 0)
                    sum += nextNumber;
                firstNumber = secondNumber;
                secondNumber=nextNumber;
            }
            Console.WriteLine(sum);
        }
    }
}

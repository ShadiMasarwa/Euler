using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public class Program
    {
        static void Main(string[] args)
        {
            long num = 600_851_475_143;
            long maxPrimeFactor = 2;



            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                //Find if prime
                bool prime = true;
                for (long j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0)
                        prime = false;

                if (num % i == 0 && prime)
                    maxPrimeFactor = i;
               
            }
            Console.WriteLine(maxPrimeFactor);
            SolveProblem3();
        }
        public static void SolveProblem3()
        {
            long num = 21;

            long upper = (long)Math.Sqrt(num);
            //Console.WriteLine(upper * upper);

            if (upper % 2 == 0) upper--;
            //Console.WriteLine("upper = " + upper ) ;
            for (long i = upper; i >= 3; i -= 2)
            {
                if (num % i == 0)
                {
                    if (MathServices.IsPrime(i))
                    {
                        Console.WriteLine("Result = " + i);
                        return;
                    }
                }
            }

        }
    }

    public class MathServices
    {


        public static bool IsPrime(long num)
        {
            if (num < 2) { return false; }
            else if (num == 2 || num == 3) { return true; }
            else if (num % 2 == 0) { return false; }

            //getting upper bound 

            long upper = (long)Math.Sqrt(num);

            //I think that because it's odd number it's always odd, and no need to do it odd
            // -- after checking - it's not true, so let set it even
            if (upper % 2 == 0) upper--;

            //Console.WriteLine("Upper = " + upper);

            for (int i = 3; i <= upper; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

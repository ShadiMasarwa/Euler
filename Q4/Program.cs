using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int r = 6;
            string str = r;
            int maxPalindrome;
            string str = "";
            for (int i=100; i<1000; i++)
            {
                for(int j=i; j<1000; j++)
                {
                    if (IsPalindrome(i*j))
                    {
                        maxPalindrome = i * j;
                        str = i.ToString() + " X " + j.ToString() + " = " + maxPalindrome;
                    }
                }
            }
            Console.WriteLine(str);
        }

        static bool IsPalindrome(int num)
        {
            int newNum=0;
            int tempNum = num;
            while (tempNum > 0)
            {
                newNum = newNum * 10 + tempNum % 10;
                tempNum /= 10;
            }
            if (num==newNum)
                return true;
            return false;
        }
    }
}

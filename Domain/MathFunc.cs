using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork7.Domain
{
    public class MathFunc
    {
        public static void IsEven(int[] array)
        {
            Console.WriteLine("\nEven numbers:");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
        public static void IsOdd(int[] array)
        {
            Console.WriteLine("\nOdd numbers:");
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
        }

        public static void IsPrime(int[] array)
        {
            Console.WriteLine("\nPrime numbers:");
            foreach (var item in array)
            {
                if (item == 1)
                {
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(item + " ");
                }
            }
        }
        public static void IsFibonacci(int[] array)
        {
            Console.WriteLine("\nFibonacci numbers:");
            foreach (var item in array)
            {
                int a = 0;
                int b = 1;
                int c = 0;
                while (c < item)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                if (c == item)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

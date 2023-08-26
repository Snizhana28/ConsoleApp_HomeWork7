using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork7.Domain
{
    public class Method
    {
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
        }
        public static void ShowDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.ToString("dddd"));
        }
        public static void ShowTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площа трикутника = {s}");
        }
        public static void ShowRectangleArea(double a, double b)
        {
            double s = a * b;
            Console.WriteLine($"Площа прямокутника = {s}");
        }

    }
}

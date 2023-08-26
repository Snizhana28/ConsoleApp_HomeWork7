using System;
using ConsoleApp_HomeWork7.Domain;
namespace ConsoleApp_HomeWork7.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Action action = Method.ShowTime;
            action += Method.ShowDate;
            action += Method.ShowDayOfWeek;
            action();
            Console.WriteLine();

            Action<double, double, double> func = Method.ShowTriangleArea;
            func(3, 4, 5);

            Action<double, double> func2 = Method.ShowRectangleArea;
            func2(3, 4);
        }
    }
}
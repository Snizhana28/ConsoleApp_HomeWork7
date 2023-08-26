using ConsoleApp_HomeWork7.Domain;
namespace ConsoleApp_HomeWork7.Internal
{
    internal class Program
    {
        delegate void MyDelegate(int[] array);
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            MathFunc mathFunc = new MathFunc();
            MyDelegate myDelegate = MathFunc.IsEven;
            myDelegate += MathFunc.IsOdd;
            myDelegate += MathFunc.IsPrime;
            myDelegate += MathFunc.IsFibonacci;
            myDelegate(array);
            Console.WriteLine();
        }
    }
}
using System.Diagnostics.CodeAnalysis;

namespace CodeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            float number2 = float.Parse(Console.ReadLine());
            float result = number1 + number2;
            Console.WriteLine(" the result is " +result);
            float average = result/ 2;
            Console.WriteLine("the average is :" +average);
            
            
        }
    }
}

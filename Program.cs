using System.Diagnostics.CodeAnalysis;

namespace CodeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Welcome to system");
                Console.WriteLine("select the process you need:");
                Console.WriteLine("1.The avrage of to numbers. ");
                Console.WriteLine("2. Check if a number is even or odd.");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                 case 1:

                Console.WriteLine("Enter the first number");
                float number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                float number2 = float.Parse(Console.ReadLine());
                float result = number1 + number2;
                Console.WriteLine(" the result is " + result);
                float average = result / 2;

                Console.WriteLine("the average is :" + average);

                break;

                case 2:

                        Console.WriteLine("Enter the number");
                        float number = float.Parse(Console.ReadLine());

                        if (number % 2 == 0)
                        {
                            Console.WriteLine("even number");

                        }

                        else
                        {
                            Console.WriteLine("odd number");


                        }

                        break;
            }

               

            
            
            }
        }
    }
}


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
                Console.WriteLine("1.The average of to numbers. ");
                Console.WriteLine("2. Check if a number is even or odd.");
                Console.WriteLine("3. Find the smallest number.");
                Console.WriteLine("task A.Multiplication table form")
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

                    case 3:

                        Console.WriteLine("Enter the that you want");
                        int n = int.Parse(Console.ReadLine());
                        int[] num = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter number:");
                            num[i] = int.Parse(Console.ReadLine());


                        }

                        int min = num[0];

                        for (int i = 0; i < num[i]; i++)
                        {
                            if (num[i] < min)
                            {
                                min = num[i];
                            }
                        }
                        Console.WriteLine("smallest is = " + min);
                        Console.ReadLine();
                        break;


                    case A:



                        Console.WriteLine("enter the number");
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= x; i++)
                        {
                            for (int j = 1; j <= n; j++)
                            {

                                Console.WriteLine(i * j + "\t");
                            }
                            Console.WriteLine();
                        }

                }

            }
        }
    }


















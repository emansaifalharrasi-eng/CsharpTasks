using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;

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
                Console.WriteLine("task A. Multiplication table form");
                Console.WriteLine("task B. check duplicate number ");
                Console.WriteLine("4. Count positive and Nagitive");
                Console.WriteLine("6 .Find the prime number");


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

                        for (int i = 0; i < n; i++)
                        {
                            if (num[i] < min)
                            {
                                min = num[i];
                            }
                        }
                        Console.WriteLine("smallest is = " + min);
                        Console.ReadLine();
                        break;


                    case 4:



                        Console.WriteLine("Enter how many number you want:");
                        int n1 = int.Parse(Console.ReadLine());
                        int[] arr = new int[n1];


                        for (int i = 0; i < n1; i++)
                        {
                            Console.WriteLine("Enter the number");
                            arr[i] = int.Parse(Console.ReadLine());
                        }

                        int positive = 0;
                        int negative = 0;

                        for (int i = 0; i < n1; i++)
                        {


                            if (arr[i] > 0)
                            {
                                positive = positive + 1;
                                Console.WriteLine("positive number=" + positive);

                            }
                            else
                            {
                                negative = negative + 1;
                                Console.WriteLine("nagitive number" + negative);


                            }
                        }
                        break;



                    case 6:


                        Console.WriteLine("Enter any number");

                        int n6 = int.Parse(Console.ReadLine());


                        bool IsPrime = true;

                        if (n6 <= 1)
                        {
                            IsPrime = false;
                        }
                        else
                        {

                            for (int i = 2; i < n6; i++)
                            {
                                if (n6 % i == 0)
                                {

                                    IsPrime = false;
                                    break;



                                }
                            }
                        }

                        if (IsPrime)
                        {



                            Console.WriteLine(n6 + "is prime");


                        }

                        else

                        {

                            Console.WriteLine(n6 + " is not prime");


                        }







                        break;


                }
            }
        }
    }
}
    


    







        

    
        
    





                 






using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "yes";

            do
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                if (choice == "1")
                    result = num1 + num2;
                else if (choice == "2")
                    result = num1 - num2;
                else if (choice == "3")
                    result = num1 * num2;
                else if (choice == "4")
                {
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        continue;
                    }
                }
                else
                {

                    Console.WriteLine("Invalid option!");
                    continue;
                }

                Console.WriteLine("Result: " + result);

                Console.Write("Do you want to calculate again? (yes/no): ");
                again = Console.ReadLine().ToLower();
                Console.WriteLine();

            } while (again == "yes");

            Console.WriteLine("Thank you.");
        }
    }
}
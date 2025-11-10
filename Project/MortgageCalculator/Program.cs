using System;
using System.Globalization;

namespace MortgageCalculator
{
    internal class Program
    {
        static void Main()
        {
           
            CultureInfo bdCulture = new CultureInfo("bn-BD");
            bdCulture.NumberFormat.CurrencySymbol = "৳";

            Console.WriteLine("===== MORTGAGE CALCULATOR (৳ BDT) =====");
            Console.WriteLine();

            
            double salary = ReadDouble("Enter your monthly salary (or 0 to skip): ", allowZero: true);
            int creditScore = ReadInt("Enter your credit score (0 - 500): ", min: 0, max: 500);
            bool criminalRecord = ReadBool("Do you have a criminal record? (true/false): ");

            
            double loanAmount = ReadDouble("Enter desired loan amount (৳): ", min: 0.01);
            double annualInterestRate = ReadDouble("Enter annual interest rate (in %): ", min: 0.0, max: 100.0);
            int loanTermYears = ReadInt("Enter loan period (in years): ", min: 1);

            
            double monthlyInterestRate = (annualInterestRate / 100.0) / 12.0;
            int totalMonths = loanTermYears * 12;

            double monthlyPayment;
            if (Math.Abs(monthlyInterestRate) < 1e-12) 
            {
                monthlyPayment = loanAmount / totalMonths;
            }
            else
            {
                monthlyPayment = (loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalMonths))
                                 / (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);
            }

            double totalPayment = monthlyPayment * totalMonths;
            double totalInterest = totalPayment - loanAmount;

            
            Console.WriteLine("\n===== MORTGAGE SUMMARY =====");
            Console.WriteLine($"Monthly Salary: {salary.ToString("C2", bdCulture)}");
            Console.WriteLine($"Credit Score: {creditScore}");
            Console.WriteLine($"Criminal Record: {criminalRecord}");
            Console.WriteLine($"Loan Amount: {loanAmount.ToString("C2", bdCulture)}");
            Console.WriteLine($"Annual Interest Rate: {annualInterestRate}%");
            Console.WriteLine($"Loan Term: {loanTermYears} years");
            Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C2", bdCulture)}");
            Console.WriteLine($"Total Payment: {totalPayment.ToString("C2", bdCulture)}");
            Console.WriteLine($"Total Interest: {totalInterest.ToString("C2", bdCulture)}");
            Console.WriteLine("\nThank you for using the Mortgage Calculator!");
        }

        
        static double ReadDouble(string prompt, double min = double.MinValue, double max = double.MaxValue, bool allowZero = false)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine()?.Trim() ?? string.Empty;
                
                if (double.TryParse(input, out double val) ||
                    double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out val) ||
                    double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out val))
                {
                    if (!allowZero && Math.Abs(val) < 1e-12)
                    {
                        Console.WriteLine("Value cannot be zero. Try again.");
                        continue;
                    }
                    if (val < min || val > max)
                    {
                        Console.WriteLine($"Please enter a value between {min} and {max}.");
                        continue;
                    }
                    return val;
                }
                Console.WriteLine("Invalid input! Please enter a valid numeric value.");
            }
        }

        static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine()?.Trim() ?? string.Empty;
                if (int.TryParse(input, out int val))
                {
                    if (val < min || val > max)
                    {
                        Console.WriteLine($"Please enter an integer between {min} and {max}.");
                        continue;
                    }
                    return val;
                }
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }

        static bool ReadBool(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
                if (input == "true" || input == "t" || input == "yes" || input == "y")
                    return true;
                if (input == "false" || input == "f" || input == "no" || input == "n")
                    return false;
                Console.WriteLine("Invalid input! Please enter true/false (or yes/no).");
            }
        }
    }
}

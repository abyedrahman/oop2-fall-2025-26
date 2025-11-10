using System;
using System.Globalization;

namespace MortgageCalculator
{
    internal class Program
    {
<<<<<<< HEAD
        static void Main()
        {
           
            CultureInfo bdCulture = new CultureInfo("bn-BD");
            bdCulture.NumberFormat.CurrencySymbol = "৳";

            Console.WriteLine("Mortgage Calculator (Bangladesh)");
            Console.WriteLine();

            double salary = 0;
            int creditScore = 0;
            bool criminalRecord = false;

           
            while (true)
            {
                Console.Write("Enter your monthly salary: ");
                string input = Console.ReadLine() ?? string.Empty.Trim(); 
                if (double.TryParse(input, out salary) && salary > 0)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a valid numeric salary.");
            }

            
            while (true)
            {
                Console.Write("Enter your credit score (0 - 500): ");
                string input = Console.ReadLine() ?? string.Empty.Trim();
                if (int.TryParse(input, out creditScore) && creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 500.");
            }

            
            while (true)
            {
                Console.Write("Do you have a criminal record? (true/false): ");
                string input = Console.ReadLine() ?? string.Empty.Trim();
                if (bool.TryParse(input, out criminalRecord))
                    break;
                else
                    Console.WriteLine("Invalid input! Type true or false.");
            }

          
            double P; 
            double r;  
            int t;   

            while (true)
            {
                Console.Write("Enter your desired loan amount: ");
                string input = Console.ReadLine() ?? string.Empty.Trim();
                if (double.TryParse(input, out P) && P > 0)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a valid loan amount.");
            }

            while (true)
            {
                Console.Write("Enter annual interest rate (in %): ");
                string input = Console.ReadLine() ?? string.Empty.Trim();
                if (double.TryParse(input, out r) && r > 0 && r < 100)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a valid interest rate (0–100).");
            }

            while (true)
            {
                Console.Write("Enter loan period in years: ");
                string input = Console.ReadLine() ?? string.Empty.Trim();
                if (int.TryParse(input, out t) && t > 0)
                    break;
                else
                    Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

           
            double monthlyInterestRate = (r / 100) / 12;
            int n = t * 12;

            double m = (P * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, n)) /
                       (Math.Pow(1 + monthlyInterestRate, n) - 1);

            double totalPaid = m * n;
            double totalInterest = totalPaid - P;

            
            Console.WriteLine();
            Console.WriteLine("== Mortgage Summary ==");
            Console.WriteLine($"Monthly Salary: {salary.ToString("N2", bdCulture)}৳");
            Console.WriteLine($"Credit Score: {creditScore}");
            Console.WriteLine($"Criminal Record: {criminalRecord}");
            Console.WriteLine($"Loan Amount: {P.ToString("N2", bdCulture)}৳");
            Console.WriteLine($"Monthly Payment: {m.ToString("N2", bdCulture)}৳");
            Console.WriteLine($"Total Payment: {totalPaid.ToString("N2", bdCulture)}৳");
            Console.WriteLine($"Total Interest: {totalInterest.ToString("N2", bdCulture)}৳");
        }
=======
        Console.WriteLine("===== MORTGAGE CALCULATOR (৳ BDT) =====\n");
        
        Console.Write("Enter Loan Amount (৳): ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Annual Interest Rate (%): ");
        double annualInterestRate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Loan Term (years): ");
        int loanTermYears = Convert.ToInt32(Console.ReadLine());
        double monthlyInterestRate = (annualInterestRate / 100) / 12;
        int totalMonths = loanTermYears * 12;
        
        double monthlyPayment = (loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalMonths))
                                / (Math.Pow(1 + monthlyInterestRate, totalMonths) - 1);
        
        double totalPayment = monthlyPayment * totalMonths;
        double totalInterest = totalPayment - loanAmount;
    
        Console.WriteLine("\n===== MORTGAGE DETAILS =====");
        Console.WriteLine($"Loan Amount: ৳{loanAmount:N2}");
        Console.WriteLine($"Annual Interest Rate: {annualInterestRate}%");
        Console.WriteLine($"Loan Term: {loanTermYears} years");
        Console.WriteLine($"Monthly Payment: ৳{monthlyPayment:N2}");
        Console.WriteLine($"Total Payment: ৳{totalPayment:N2}");
        Console.WriteLine($"Total Interest: ৳{totalInterest:N2}");
        Console.WriteLine("\nThank you for using the Mortgage Calculator!");
>>>>>>> cebf87c40063daa4eea56739f3ee9364585b2c4c
    }
}
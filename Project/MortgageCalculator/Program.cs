using System;
class MortgageCalculator
{
    static void Main()
    {
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
    }
}

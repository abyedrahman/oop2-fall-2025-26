using System;

class Program
{
    static void Main()
    {
        double price = 250;
        double discountRate = 0.15;
        double discountAmount, finalPrice;

        discountAmount = price * discountRate;
        finalPrice = price - discountAmount;

        Console.WriteLine($"Original Price: ${price}");
        Console.WriteLine($"Discount: 15%");
        Console.WriteLine($"Final Price after discount: ${finalPrice:F2}");

    }
}

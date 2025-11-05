using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Swapping using arithmetic (no temp variable)
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}

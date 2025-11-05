using System;

class Program
{
    static void Main()
    {
        int score1, score2, score3;
        double average;

        Console.Write("Enter score of student 1: ");
        score1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter score of student 2: ");
        score2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter score of student 3: ");
        score3 = Convert.ToInt32(Console.ReadLine());

        average = (score1 + score2 + score3) / 3.0;  // use 3.0 to get decimal result

        Console.WriteLine($"Average score = {average:F2}");
    }
}

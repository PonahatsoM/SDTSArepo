using System;

class Program
{
    static void Main()
    {
        // Prompt for student name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // Array to store marks
        int[] marks = new int[3];
        int total = 0;

        // Loop to collect and validate marks
        for (int i = 0; i < 3; i++)
        {
            bool valid = false;
            while (!valid)
            {
                Console.Write($"Enter mark for subject {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int mark))
                {
                    marks[i] = mark;
                    total += mark;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }

        // Calculate average
        double average = total / 3.0;

        // Determine PASS/FAIL
        string result = average >= 50 ? "PASS" : "FAIL";

        // Display results
        Console.WriteLine("\n--- Student Results ---");
        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Subject 1: {marks[0]}");
        Console.WriteLine($"Subject 2: {marks[1]}");
        Console.WriteLine($"Subject 3: {marks[2]}");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average:F2}");
        Console.WriteLine($"Result: {result}");
    }
}
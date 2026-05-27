using System;

class ATMApp
{
    static void Main()
    {
        // Initial balance
        decimal balance = 1000.00m;

        Console.WriteLine(" Welcome to the Structure of a C# Program Demo");
        Console.WriteLine("Your current balance: {balance:C}");

        // Prompt for student name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();


        if (decimal.TryParse(input, out decimal withdrawalAmount))
        {
            if (withdrawalAmount <= 0)
            {
                Console.WriteLine("Invalid amount. Withdrawal must be greater than zero.");
            }
            else if (withdrawalAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Transaction declined.");
            }
            else
            {
                // Perform withdrawal
                balance -= withdrawalAmount;

                // Display transaction details
                Console.WriteLine("\n--- Transaction Receipt ---");
                Console.WriteLine($"Withdrawal Amount: {withdrawalAmount:C}");
                Console.WriteLine($"Updated Balance: {balance:C}");
                Console.WriteLine($"Transaction Time: {DateTime.Now}");
                Console.WriteLine("Transaction Successful!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        Console.WriteLine("\nThank you for using Simple ATM!");
    }
}

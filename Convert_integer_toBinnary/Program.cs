using System;

class Program
{
    static void Main(string[] args)
    {
        // Define an integer value to convert
        int number = 25;

        // Convert the integer to binary using Convert.ToString() method
        string binaryRepresentation = Convert.ToString(number, 2);

        // Print the result
        Console.WriteLine($"The binary representation of {number} is: {binaryRepresentation}");

        // Allow the user to enter a number
        Console.WriteLine("\nEnter an integer to convert it to binary:");
        int inputNumber = int.Parse(Console.ReadLine());

        // Convert user input to binary and print
        string binaryResult = Convert.ToString(inputNumber, 2);
        Console.WriteLine($"The binary representation of {inputNumber} is: {binaryResult}");

        Console.ReadLine();
    }
}

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        char[] spinner = new char[] { '-', '+' };
        int spinnerIndex = 0;

        while (true) // Replace with a condition to stop the spinner
        {
            Console.Write("\r" + spinner[spinnerIndex]); // Overwrite the entire line with the new character
            spinnerIndex = (spinnerIndex + 1) % spinner.Length; // Move to the next character in the spinner array
            Thread.Sleep(500); // Wait before the next character
        }
    }
}
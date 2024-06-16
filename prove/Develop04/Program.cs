using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity(
                    "Breathing",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
                );
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(
                    "Reflecting",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
                );
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity(
                    "Listing",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
                );
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }
    }
}

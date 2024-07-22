using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Anytown", "Anystate", "USA");
        Address receptionAddress = new Address("456 Elm St", "Othertown", "Otherstate", "USA");
        Address outdoorGatheringAddress = new Address("789 Park Ave", "Parktown", "Parkstate", "USA");

        Event lecture = new Lecture("Tech Talk", "A talk on the latest in technology", "2024-08-01", "10:00 AM", lectureAddress, "Dr. Smith", 100);
        Event reception = new Reception("Company Mixer", "An evening of networking", "2024-08-01", "6:00 PM", receptionAddress, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Picnic", "A fun day at the park", "2024-08-02", "12:00 PM", outdoorGatheringAddress, "Sunny");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event evt in events)
        {
            Console.WriteLine("-------------Standard Details-------------");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("-------------Full Details-------------");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine("-------------Short Description-------------");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

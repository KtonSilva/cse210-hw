using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "San Francisco", "CA", "USA");

        // Create events
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in tech", new DateTime(2024, 7, 10), "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Wedding Reception", "Celebrate the wedding of Jane and John", new DateTime(2024, 8, 20), "6:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun picnic for the community", new DateTime(2024, 9, 5), "12:00 PM", address3, "Sunny and warm");

        // Add events to a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event information
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}

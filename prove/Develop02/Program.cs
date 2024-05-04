using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal myJournal = new Journal();

        // Add some entries
        myJournal.AddEntry(new Entry("2024-05-04", "What was the best part of my day?", "The sunrise was beautiful today."));
        myJournal.AddEntry(new Entry("2024-05-04", "Who was the most interesting person I interacted with today?", "I had a fascinating conversation with my neighbor."));
        myJournal.AddEntry(new Entry("2024-05-03", "How did I see the hand of the Lord in my life today?", "I found peace in a difficult situation."));
        myJournal.AddEntry(new Entry("2024-05-03", "What was the strongest emotion I felt today?", "I felt a surge of joy when I accomplished my task."));

        // Display the journal entries
        Console.WriteLine("Displaying Journal Entries:");
        myJournal.Display();

        // Save the journal to a file
        myJournal.SaveToFile("my_journal.txt");
        Console.WriteLine("Journal saved to file.");

        // Load the journal from a file
        Journal loadedJournal = new Journal();
        loadedJournal.LoadFromFile("my_journal.txt");
        Console.WriteLine("\nJournal loaded from file. Displaying loaded entries:");
        loadedJournal.Display();
    }
}
using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    class ListingActivity : Activity
    {
        private List<string> _prompts;

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(3);

            Console.WriteLine("Start listing items:");
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"You listed {items.Count} items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }

            DisplayEndingMessage();
        }
    }
}

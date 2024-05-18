using System;
using System.Threading;

namespace MindfulnessApp
{
    class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            ClearConsole();
            Console.WriteLine($"Starting {_name} Activity");
            Console.WriteLine(_description);
            Console.Write("Enter the duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("Good job!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        static void ClearConsole()
        {
            try
            {
                Console.Clear();
            }
            catch (IOException)
            {
                // Ignore error if unable to clear console
            }
        }
    }
}

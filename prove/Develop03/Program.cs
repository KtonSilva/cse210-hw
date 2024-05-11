using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Define a escritura
        string[] scriptureText = {
            "For God so loved the world, that he gave his only begotten Son,",
            "that whosoever believeth in him should not perish,",
            "but have everlasting life."
        };

        // Exibir a escritura original
        DisplayScripture(scriptureText);
        Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

        bool allWordsHidden = false;
        string input;
        while ((input = Console.ReadLine()) != "quit" && !allWordsHidden)
        {
            // Ocultar algumas palavras da escritura
            allWordsHidden = HideRandomWords(scriptureText);
            if (!allWordsHidden)
            {
                Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");
            }
        }

        if (allWordsHidden)
        {
            Console.WriteLine("\nAll words in the scripture are hidden. Press ENTER to exit.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }

    // Função para ocultar algumas palavras da escritura
    static bool HideRandomWords(string[] scripture)
    {
        Random random = new Random();
        bool anyWordHidden = false;
        for (int i = 0; i < scripture.Length; i++)
        {
            string[] words = scripture[i].Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] != "_____" && random.Next(2) == 0) // Probabilidade de ocultar cada palavra é de 50%
                {
                    words[j] = new string('_', words[j].Length);
                    anyWordHidden = true;
                }
            }
            scripture[i] = string.Join(" ", words);
            Console.WriteLine(scripture[i]);
        }
        return !anyWordHidden;
    }

    // Função para exibir a escritura
    static void DisplayScripture(string[] scripture)
    {
        foreach (var line in scripture)
        {
            Console.WriteLine(line);
        }
    }
}

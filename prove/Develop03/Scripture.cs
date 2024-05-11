class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string[] text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string line in text)
        {
            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                _words.Add(new Word(word));
            }
            // Add a space after each line
            _words.Add(new Word(" "));
        }
        // Remove the extra space at the end
        _words.RemoveAt(_words.Count - 1);
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
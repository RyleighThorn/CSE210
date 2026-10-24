class Scripture
{
    List<Word> _words;
    private Scripture_reference _Reference;

    public Scripture(string BookName, int Chapter, int Verse, string text)
    {
        _Reference = new Scripture_reference(BookName, Chapter, Verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string BookName, int Chapter, int startVerse, int endVerse, string text)
    {
        _Reference = new Scripture_reference(BookName, Chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(Scripture_reference Reference, string text)
    {
        _Reference = Reference;
        _words = ConvertToWords(text);
    }

    public void ShowScripture()
    {
        Console.WriteLine(_Reference.GetDisplay());
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    //converttowords will convert the paragraph that is in the text parameter to a list of words
    //the list of words is returned
    private List<Word> ConvertToWords(string text) //gets paragraph
    {
        List<Word> tempWords = new List<Word>(); // makes list of word objects

        string[] words = text.Split(' '); // split it on every space character and get array of words
        //foreach(string word in text.Split(' '))
        foreach(string word in words)
        {
            Word tempWord = new Word(word); // make new object
            tempWords.Add(tempWord); //add it into a list
        }
        return tempWords;//return that list
    }
    public void HideRandom(int HiddenNumber)
    {
        Random random = new Random();
        for (int i = 0; i < HiddenNumber; i++)
        {
            List<Word> usedwords = new List<Word>();
            //int index = random.Next(_words.Count);
            //_words[index].HideWord();
            foreach(Word word in _words)
            {
                if (!word.IsHidden())
                {
                    usedwords.Add(word);
                }
            }
            if (usedwords.Count == 0) // no more visable words
        {
            break;
        }
        int index = random.Next(usedwords.Count);
        usedwords[index].HideWord();
        }
    }
    public bool AllAreHidden()
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
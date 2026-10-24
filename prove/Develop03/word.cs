using System.Collections.Concurrent;
using System.ComponentModel;

class Word
{
    private string _word;
    private bool _hidden; // info is private
    public Word(string word) //word is going to be called, word is natrally not hidden (constructor)
    {
        _word = word; // so we can get it look into this
        _hidden = false;
    }

    public void HideWord() //call it to hide the word
    {
        _hidden = true;
    }
    public bool IsHidden() // seperate function to see that a word is hidden, get hidden
    {
        return _hidden;
    }
    public void Display() // display the word
    {
        Console.Write($"{GetWordString()} "); // not _word becuase it needs to tell if its hidden of not
    }
    public string GetWordString() //get what the word is
    {
        string returnstring = "";
        if (_hidden){
        for (int i = 0; i < _word.Length; i++) //always formatted like this, good to remember
        {// its to start a for loop and specifically for a list/ more than just one thing 
            returnstring += '_'; //if word is hidden turn it into dash
        }
        }
        else
        {
            returnstring = _word; //if word is not hidden then just the word is returned
        }
        return returnstring;
    }

}

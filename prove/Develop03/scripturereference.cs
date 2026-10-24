class Scripture_reference
{
    private string _BookName;
    private int _Chapter;
    private int _Verse;

    private int _startVerse;
    private int _endVerse;
    public Scripture_reference(string BookName, int Chapter, int Verse)//single verse
    {
     _BookName = BookName;
     _Chapter = Chapter;
     _Verse = Verse;

    }
    public Scripture_reference(string BookName, int Chapter, int startVerse, int endVerse)
    {
        _BookName = BookName;
        _Chapter = Chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        
    }
    public string GetDisplay()
    {
        if (_endVerse > 0)
        {
            return ($"{_BookName}, {_Chapter}, {_startVerse} - {_endVerse}");
        }else{
            return ($"{_BookName}, {_Chapter}, {_Verse}");        
            }
    }
}
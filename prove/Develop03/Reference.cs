public class Reference
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse = -1;
    
    public Reference(string book, int chapter, int firstverse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstverse;
    }

    public Reference(string book, int chapter, int firstverse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstverse;
        _lastVerse = lastVerse;
    }

    public void Display()
    {
        if (_lastVerse == -1)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
    }
}
public class Reference
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse = -1;
    
    // Constructor for Reference
    public Reference(string book, int chapter, int firstverse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstverse;
    }

    // Second Constructor for Reference
    public Reference(string book, int chapter, int firstverse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstverse;
        _lastVerse = lastVerse;
    }

    // Method to display the reference
    public void Display()
    {
        // If the reference has only one verse.
        if (_lastVerse == -1)
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        }
        // If the reference has more than one verse.
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
    }
}
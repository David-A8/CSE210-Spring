public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _ref;
    
    // Constructor of Scripture
    public Scripture(string Passage, string Book, int Chapter, int Verse)
    {   
        // Converting string into a list of words.
        string[] words = Passage.Split(" ");
        for (int word = 0; word < words.Count(); word++) 
        {
            _words.Add(new Word(words[word]));
        }
        // Creating a new reference with data entered by the user.
        _ref = new Reference(Book,Chapter,Verse);
    }

    public void Display()
    {
        // Display scripture with no dashed words.
        Console.Clear();
        _ref.Display();
        for (int word = 0; word < _words.Count(); word++)
        {
            _words[word].Display();
        }
    }

    public void RandomHide()
    {
        Boolean AllLines = false;
        Word randomWord;
        Random random = new Random();
        int LineWords = 0;
        // If any of the words still visible, the following will keep showing up.
        while (AllLines == false)
        {
            // User decide if continue or quit
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish");
            // If user presses enter.
            if (Console.ReadLine() == "")
            {
                // Converting random words into dashes. 
                for (int i = 0; i < 5; i++)
                {
                    randomWord = _words[random.Next(0,_words.Count)];
                    randomWord.HideWord();
                }

                // Verify how many words are dashed.
                for (int word = 0; word < _words.Count(); word++)
                {
                    if (_words[word].Verify() == true)
                    {
                        LineWords ++;
                    }
                    // If all the words are dashed, the loop will stop.
                    if (LineWords == _words.Count())
                    {
                        AllLines = true;
                    }
                }
                // Displaying the scripture with dashed words.
                LineWords = 0;
                Console.Clear();
                _ref.Display();
                for (int word = 0; word < _words.Count(); word++)
                {
                    _words[word].Display();
                }
            }
            // If the user types 'quit', the loop will end.
            else
            {
                break;
            }
        }
    }
    
    
}
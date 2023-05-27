public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _ref;
    
    public Scripture(string Passage, string Book, int Chapter, int Verse)
    {   
        string[] words = Passage.Split(" ");
        for (int word = 0; word < words.Count(); word++) 
        {
            _words.Add(new Word(words[word]));
        }
        _ref = new Reference(Book,Chapter,Verse);
    }

    public void Display()
    {
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
        while (AllLines == false)
        {
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish");
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
                    if (LineWords == _words.Count())
                    {
                        AllLines = true;
                    }
                }
                LineWords = 0;
                Console.Clear();
                _ref.Display();
                for (int word = 0; word < _words.Count(); word++)
                {
                    _words[word].Display();
                }
            }
            else
            {
                break;
            }
        }
    }
    
    
}
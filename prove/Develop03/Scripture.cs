public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _ref;
    
    public Scripture(string Passage, string Reference)
    {   
        string[] words = Passage.Split(" ");
        for (int word = 0; word < words.Count(); word++) 
        {
            _words.Add(new Word(words[word]));
        }
    }

    public void Display()
    {
        for (int word = 0; word < _words.Count(); word++)
        {
            _words[word].Display();
        }
    }
    
    
}
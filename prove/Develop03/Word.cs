public class Word
{
    string _word;
    Boolean _isHidden;
    string _hiddenword;
    
    // Constructor of Word.
    public Word(string word, Boolean hidden = false)
    {
        _word = word;
        _isHidden = hidden;
        // Making the dashed version of each word.
        for (int letter = 0; letter < word.Count(); letter++) 
        {
            _hiddenword = _hiddenword + "-";
        }
    }

    // This method will hide the word from the scripture class.
    public void HideWord()
    {
        _isHidden = true;
    }

    // This method is to verify what words are already hidden from the scripture class.
    public Boolean Verify()
    {
        return _isHidden;
    }

    // Method to display either a normal word or a dashed word.
    public void Display()
    {
        if (_isHidden == false)
        {
            Console.Write((_word) + " ");
        }
        else
        {
            Console.Write((_hiddenword) + " ");
        }
    }
}
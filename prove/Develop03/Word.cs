public class Word
{
    string _word;
    Boolean _isHidden;
    string _hiddenword;

    public Word(string word, Boolean hidden = false)
    {
        _word = word;
        _isHidden = hidden;
        for (int letter = 0; letter < word.Count(); letter++) 
        {
            _hiddenword = _hiddenword + "-";
        }
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public Boolean Verify()
    {
        return _isHidden;
    }
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
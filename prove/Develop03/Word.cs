public class Word
{
    string _word;
    Boolean _isHidden;
    string _hiddenword;

    public Word(string word, Boolean hidden)
    {
        _word = word;
        _isHidden = hidden;
        for (int letter = 0; letter < word.Count(); letter++) 
        {
            _hiddenword = _hiddenword + "-";
        }
    }

    public void HideWord(string word)
    {
        _isHidden = true;
    }

    public void ShowWord(string word)
    {
        _isHidden = false;
    }
}
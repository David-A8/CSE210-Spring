public class Entry
{
    // An entry contains a Prompt, a response and a date. 
    public Prompt _prompt = new Prompt();
    public string _response = "";
    private string _date;

    // Constructor of an Entry.
    public Entry(string date, Prompt question, string response = "")
    {
        _date = date;
        _prompt = question;
        _response = response;
    }

    // Method to get entry in a string format ready to display.
    public string GetEntry()
    {
        return $"{_date}\n{_prompt.Display()}\n{_response}";
    }

    // Method to get an entry in a string format ready to save in a text file.
        public string GetText()
    {
        return $"{_date}~~{_prompt.Display()}~~{_response}";
    }







}
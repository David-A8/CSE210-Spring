public class Entry
{
    private Prompt _prompt;
    private string _response = "";
    private DateTime _date;

    public Entry(DateTime date, Prompt question, string response = "")
    {
        _date = date;
        _prompt = question;
        _response = response;
    }


    public string GetEntry()
    {
        return $"{_date.ToString("M/d/yyy")}\n{_prompt.Display()}\n{_response}";
    }







}
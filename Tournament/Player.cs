public class Player
{
    private string _firstName;
    private string _lastName;
    private int _jersey;

    public Player(string firstName, string lastName, int jerseyNumber)
    {
        _firstName = firstName;
        _lastName = lastName;
        _jersey = jerseyNumber;
    }

    public void UpdateJersey(int newNumber)
    {
        _jersey = newNumber;
    }

    public void Display()
    {
        Console.WriteLine($"{_firstName}, {_lastName}: {_jersey}");
    }
    
    
public int GetJersey()
{
    return _jersey;
}





}
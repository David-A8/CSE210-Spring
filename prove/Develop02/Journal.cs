public class Journal
{
    // Creates a journal with several entries.
    List<Entry> _entries = new List<Entry>();
    string _fileText;

    // Method to create a nice and clean format before display.
    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine(item);
        Console.WriteLine("-----------------------------------------------------------------");
    }

    // Method to create a string variable with all the info needed for a text file.
    public void CreateText()
    {
        _fileText = "";
         foreach (Entry entry in _entries)
        {
            _fileText = _fileText + entry.GetText() + $"\n";
        }
    }

    // Method to send the variable created in the previous method to save file.
    public string DisplayFile()
    {
        return _fileText;
    }
    
    // Method to display in a nice format all the information in the journal.
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            NicePrint(entry.GetEntry());
        }
    }

    // Method to add more entries to the journal.
    public void AddEntries(Entry entry)
    {
        _entries.Add(entry);
    }


}
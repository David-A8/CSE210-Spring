public class Journal
{
    List<Entry> _entries = new List<Entry>();
    string _fileText;

    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine(item);
        Console.WriteLine("-----------------------------------------------------------------");
    }

    public void CreateText()
    {
         foreach (Entry entry in _entries)
        {
            _fileText = _fileText + entry.GetEntry() + $"\n---------------------------------------------------------------\n";
        }
    }
    public string DisplayFile()
    {
        return _fileText;
    }
    
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            NicePrint(entry.GetEntry());
        }
    }

    public void AddEntries(Entry entry)
    {
        _entries.Add(entry);
    }


}
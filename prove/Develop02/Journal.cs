public class Journal
{
    List<Entry> _entries = new List<Entry>();

    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine(item);
        Console.WriteLine("-----------------------------------------------------------------");


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
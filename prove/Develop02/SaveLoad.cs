using System.Globalization;

// Method to save a journal into a txt file.
public class SaveLoad
{
    public void Save(string file, Journal info)
    {
        info.CreateText();
        using (StreamWriter outputFile = new StreamWriter(file + ".txt"))
        {
            outputFile.WriteLine(info.DisplayFile());
        }
    }

    // Method to load a journal from a txt file.
    public void Load(string Loadfile)
    {
        string fileName = Loadfile;
        string[] lines = System.IO.File.ReadAllLines(Loadfile);
        Journal newJournal = new Journal();
        Menu newMenu = new Menu(newJournal);

        // Load text file and convert it to a journal.
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Console.WriteLine(parts[0]);
            DateTime date = DateTime.ParseExact(parts[0], ("M/d/yyyy"), CultureInfo.CurrentCulture);
            string response = parts[2];
            newJournal.AddEntries(new Entry(date, new Prompt(), response));
        }
        newMenu.Display();
    }
}
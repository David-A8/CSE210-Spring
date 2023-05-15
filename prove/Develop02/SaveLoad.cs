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

    // Method to load a journal from a txt file (enter name only WITHOUT .TXT).
    public void Load(string Loadfile)
    {
        string fileName = Loadfile;
        string[] lines = System.IO.File.ReadAllLines(Loadfile + ".txt");
        Journal newJournal = new Journal();
        Menu newMenu = new Menu(newJournal);

        // Load text file and convert it to a journal (enter name only WITHOUT .TXT).
        for (int i = 0; i < lines.Count() - 1; i++)
        {
            string[] parts = lines[i].Split("~~");
            //DateTime date = DateTime.ParseExact(parts[0], ("M/d/yyyy"), CultureInfo.CurrentCulture);
            newJournal.AddEntries(new Entry(parts[0], new Prompt(parts[1]), parts[2]));
        }
        newMenu.Display();
    }
}
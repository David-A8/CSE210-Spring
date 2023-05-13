public class SaveLoad
{
    private Journal _info;


    public void Save(string file, Journal info)
    {
        _info = info;
        _info.CreateText();
        using (StreamWriter outputFile = new StreamWriter(file + ".txt"))
        {
            outputFile.WriteLine(_info.DisplayFile());
        }
    }

    public void Load(string file)
    {

    }
}
public class MediaCollection
{
    List<Media> _collection = new List<Media>();

    public void LoadMedia()
    {
        string[] lines = System.IO.File.ReadAllLines("Media.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(":/");
            if (parts[0] == "Music")
            {
                _collection.Add(new Music());
            }
            else if (parts[0] == "Movie"){
                _collection.Add(new Movie());
            }
            else if (parts[0] == "TvShow"){
                _collection.Add(new TvShow());
            }
            _collection[_collection.Count - 1].LoadingData(parts);
        }
    }
    
    public void SaveMedia()
    {
        using(StreamWriter outputFile = new StreamWriter("Media.txt"))
        {
            for (int i = 0; i < _collection.Count; i++)
            {
                outputFile.WriteLine(_collection[i].GetTxtInfo());
            }
        }
    }
}
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        string filename = "Journal.csv";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                outputFile.WriteLine($"{i._date}~~{i._promptText}~~{i._entryText}");
            }
        }
    }
    public List<Entry> LoadFromFile()
    {
        List<Entry> _entries = new List<Entry>();
        string filename = "Journal.csv";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            Console.WriteLine($"Date: {newEntry._date} - Prompt: {newEntry._promptText} {newEntry._entryText}");
        }

        return _entries;
    }

}
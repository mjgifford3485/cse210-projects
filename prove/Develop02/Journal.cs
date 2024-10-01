using System.Formats.Asn1;
using System.IO;
public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine("Date,Prompt Text,Entry Text");
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\"");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry { _date = parts[0], _promptText = parts[1], _entryText = parts[2]});
                }
            }
        }
    }
}
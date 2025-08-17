namespace SingleResponsibilityPrinciple;

public class Journal
{
    private readonly List<string> _entries = new();
    
    private static int count = 0;

    public int AddEntry(string text)
    {
        _entries.Add($"{++count}: {text}");
        return count;   // memento
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    /*
     * Avoid this and create a separate class for persistence
     * 
    * public void Save(string filename)
    * {
    *     File.WriteAllText(filename, ToString());
    * }
    */
    
    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }
}
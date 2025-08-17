namespace SingleResponsibilityPrinciple;

public class Persistence
{
    public static void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
        {
            File.WriteAllText(filename, journal.ToString());
        }
    }
}
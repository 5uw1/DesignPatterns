using System.Diagnostics;
using SingleResponsibilityPrinciple;

var journal = new Journal();
journal.AddEntry("I learn today");
journal.AddEntry("I ate a banana");
Console.WriteLine(journal);

var filename = @"C:\temp\journal.txt";
Persistence.SaveToFile(journal, filename, true);
Process.Start(new ProcessStartInfo(filename) { UseShellExecute = true });
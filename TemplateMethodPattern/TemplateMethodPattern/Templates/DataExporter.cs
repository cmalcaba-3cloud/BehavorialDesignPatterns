namespace TemplateMethodPattern.Templates;

public abstract class DataExporter
{
    public void Export(string reportName)
    {
        Console.WriteLine($"Preparing {reportName}...");
        Console.WriteLine(FormatData(reportName));
        Console.WriteLine("Export complete.\n");
    }

    protected abstract string FormatData(string reportName);
}

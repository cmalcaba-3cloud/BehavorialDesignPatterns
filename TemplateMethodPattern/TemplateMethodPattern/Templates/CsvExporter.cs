namespace TemplateMethodPattern.Templates;

public class CsvExporter : DataExporter
{
    protected override string FormatData(string reportName) => $"{reportName}.csv -> id,name,total";
}

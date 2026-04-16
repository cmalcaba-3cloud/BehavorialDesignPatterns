namespace TemplateMethodPattern.Templates;

public class JsonExporter : DataExporter
{
    protected override string FormatData(string reportName) => $"{reportName}.json -> {{ \"items\": [] }}";
}

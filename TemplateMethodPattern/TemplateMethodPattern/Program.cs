using TemplateMethodPattern.Templates;

Console.WriteLine("== Template Method Pattern: Data Export ==\n");

new CsvExporter().Export("sales-report");
new JsonExporter().Export("inventory-report");

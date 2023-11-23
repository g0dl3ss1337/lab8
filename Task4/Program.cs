namespace Task4;

class Program
{
    static void Main()
    {
        
        IDataTemplate csvData = new CsvDataTemplate();
        IDataTemplate xmlData = new XmlDataTemplate();
        IDataTemplate jsonData = new JsonDataTemplate();

        // Створення екземпляра адаптера
        IDataAdapter adapter = new DataAdapter();

        // Створення екземпляра обробника даних
        DataProcessor dataProcessor = new DataProcessor();

        // Вибір користувача вхідних та вихідних даних
        Console.WriteLine("Виберіть вхідний формат даних (CSV, XML, JSON): ");
        string sourceFormat = Console.ReadLine().ToUpper();

        Console.WriteLine("Виберіть вихідний формат даних (CSV, XML, JSON): ");
        string targetFormat = Console.ReadLine().ToUpper();

        // Вибір відповідних шаблонів даних
        IDataTemplate sourceTemplate = GetTemplateByFormat(sourceFormat);
        IDataTemplate targetTemplate = GetTemplateByFormat(targetFormat);

        // Обробка даних
        dataProcessor.ProcessData(sourceTemplate, targetTemplate, adapter);

        Console.ReadLine();
    }

    private static IDataTemplate GetTemplateByFormat(string format)
    {
        switch (format)
        {
            case "CSV":
                return new CsvDataTemplate();
            case "XML":
                return new XmlDataTemplate();
            case "JSON":
                return new JsonDataTemplate();
            default:
                throw new ArgumentException("Неправильний формат.");
        }
    }
}

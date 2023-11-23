namespace Task4;

public class CsvDataTemplate : IDataTemplate
{
    private string data;

    public void LoadData(string data)
    {
        this.data = data;
        Console.WriteLine("Імпортовані дані CSV: " + data);
    }

    public string ExportData()
    {
        Console.WriteLine("Експортовані дані CSV: " + data);
        return data;
    }
}

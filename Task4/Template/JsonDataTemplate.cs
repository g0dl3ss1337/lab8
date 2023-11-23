namespace Task4;

public class JsonDataTemplate : IDataTemplate
{
    private string data;

    public void LoadData(string data)
    {
        this.data = data;
        Console.WriteLine("Імпортовані дані JSON: " + data);
    }

    public string ExportData()
    {
        Console.WriteLine("Експортовані дані JSON: " + data);
        return data;
    }
}

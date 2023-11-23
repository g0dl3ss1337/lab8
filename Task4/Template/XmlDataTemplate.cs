namespace Task4;

public class XmlDataTemplate : IDataTemplate
{
    private string data;

    public void LoadData(string data)
    {
        this.data = data;
        Console.WriteLine("Імпортовані дані XML: " + data);
    }

    public string ExportData()
    {
        Console.WriteLine("Експортовані дані XML: " + data);
        return data;
    }
}

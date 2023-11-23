namespace Task4;

public class DataProcessor
{
    public void ProcessData(IDataTemplate sourceData, IDataTemplate targetData, IDataAdapter adapter)
    {
        // Завантаження даних з вихідного формату
        string inputData = sourceData.ExportData();
        targetData.LoadData(inputData);

        // Адаптація даних, якщо необхідно
        targetData = adapter.AdaptData(targetData);

        // Експорт даних у цільовий формат
        string outputData = targetData.ExportData();
        Console.WriteLine("Конвертація даних завершена.");
    }
}

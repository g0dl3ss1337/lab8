namespace Task4;

public class DataAdapter : IDataAdapter
{
    public IDataTemplate AdaptData(IDataTemplate sourceData)
    {
        // Логіка адаптації даних з одного формату в інший.

        // У цьому прикладі, адаптер не змінює формат, просто повертає вхідні дані

        return sourceData;
    }
}

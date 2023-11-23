namespace Task3;

class Snapdragon : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Процесор Snapdragon.");
    }
}

class AppleA14 : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Процесор Apple A14.");
    }
}

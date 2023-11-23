namespace Task3;

class OLED : IScreen
{
    public void Display()
    {
        Console.WriteLine("OLED-екран.");
    }
}

class AMOLED : IScreen
{
    public void Display()
    {
        Console.WriteLine("AMOLED-екран.");
    }
}

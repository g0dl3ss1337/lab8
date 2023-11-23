namespace Task3;

class SonyCamera : ICamera
{
    public void Capture()
    {
        Console.WriteLine("Камера Sony.");
    }
}

class SamsungCamera : ICamera
{
    public void Capture()
    {
        Console.WriteLine("Камера Samsung.");
    }
}

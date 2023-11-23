namespace Task3;

class SmartphoneFactory : ITechProductFactory
{
    public IScreen CreateScreen()
    {
        return new OLED();
    }

    public IProcessor CreateProcessor()
    {
        return new Snapdragon();
    }

    public ICamera CreateCamera()
    {
        return new SonyCamera();
    }
}

namespace Task3;

class TabletFactory : ITechProductFactory
{
    public IScreen CreateScreen()
    {
        return new AMOLED();
    }

    public IProcessor CreateProcessor()
    {
        return new AppleA14();
    }

    public ICamera CreateCamera()
    {
        return new SamsungCamera();
    }
}

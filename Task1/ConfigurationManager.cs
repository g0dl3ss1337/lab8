using System;

public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private string logMode;
    private string databaseConnection;

    private ConfigurationManager()
    {
        // Встановлення дефолтних значень
        logMode = "ІНФО";
        databaseConnection = "Підключенно";
    }

    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    public string LogMode
    {
        get { return logMode; }
        set
        { 
            logMode = value;
            Console.WriteLine($"Режим логування встановлено на: {logMode}");
        }
    }

    public string DatabaseConnection
    {
        get { return databaseConnection; }
        set
        {        
            databaseConnection = value;
            Console.WriteLine($"Підключення до бази даних встановлено на: {databaseConnection}");
        }
    }
}

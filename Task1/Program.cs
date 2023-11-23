using System;
using System.Text;

namespace Task1;

class Program
{
    static void Main()
    {

        // Встановлення налаштування для вводу/виводу для коректного відображення і отримування тексту з консолі.
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        // Використання Singleton ConfigurationManager
        ConfigurationManager configManager = ConfigurationManager.Instance;

        // Демонстрація доступу та зміни конфігураційних налаштувань через консольний інтерфейс
        while (true)
        {
            Console.WriteLine("1. Переглянути режим логування");
            Console.WriteLine("2. Встановити режим логування");
            Console.WriteLine("3. Переглянути підключення до бази даних");
            Console.WriteLine("4. Встановити підключення до бази даних");
            Console.WriteLine("5. Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Поточний режим логування: {configManager.LogMode}");
                    break;

                case "2":
                    Console.Write("Введіть новий режим логування: ");
                    string newLogMode = Console.ReadLine();
                    configManager.LogMode = newLogMode;
                    break;

                case "3":
                    Console.WriteLine($"Поточне підключення до бази даних: {configManager.DatabaseConnection}");
                    break;

                case "4":
                    Console.Write("Введіть нове підключення до бази даних: ");
                    string newDbConnection = Console.ReadLine();
                    configManager.DatabaseConnection = newDbConnection;
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, введіть правильну опцію.");
                    break;
            }
        }
    }
}

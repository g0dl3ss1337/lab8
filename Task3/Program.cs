using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Виберіть тип технологічного продукту ( 1 - Смартфон, 2 - Планшет ):");
            int choice;

            // Перевірка правильності введення користувача
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Неправильне введення. Будь ласка, введіть ціле число.");
                return;
            }

            string product = "";
            ITechProductFactory factory = null;

            if (choice == 1)
            {
                factory = new SmartphoneFactory();
                product = "Смартфон";
            }
            else if (choice == 2)
            {
                factory = new TabletFactory();
                product = "Планшет";
            }
            else
            {
                Console.WriteLine("Невірний вибір. Будь ласка, введіть правильну опцію.");            
            }

            if (factory != null)
            {
                IScreen screen = factory.CreateScreen();
                IProcessor processor = factory.CreateProcessor();
                ICamera camera = factory.CreateCamera();

                Console.WriteLine($"Створено технологічний продукт: {product}");
                screen.Display();
                processor.Process();
                camera.Capture();
            }
        }
    }
}

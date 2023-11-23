using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            GraphFactory graphFactory = new GraphFactory();

            do
            {
                Console.Write("Введіть тип графіка ( line / bar / pie ): ");
                string chartType = Console.ReadLine();

                IChart chart = graphFactory.CreateChart(chartType);

                if (chart != null)
                {
                    chart.Draw();
                    break; // Вихід з циклу, якщо графік створено та візуалізовано
                }
                else
                {
                    Console.WriteLine("Помилка: Невірний вибір. Будь ласка, введіть правильну опцію.");
                }

            } while (true); // Безкінечний цикл, який виходить лише після правильного вибору графіка
        }
    }
}

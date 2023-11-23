using System;

namespace Task2
{
    public class BarChart : IChart
    {
        public void Draw()
        {
            Console.WriteLine("Малюємо стовпчиковий графік.\n");

            // Логіка малювання стовпчикового графіка у консолі
            DrawBar(3);
            DrawBar(5);
            DrawBar(2);
        }

        private void DrawBar(int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write("*");
            }
            Console.Write($" {height}"); // Виведення цифри після стовпчика
            Console.WriteLine(); // Перехід на новий рядок після завершення стовпчика
        }
    }
}

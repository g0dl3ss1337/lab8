using System;

namespace Task2
{
    public class LineChart : IChart
    {
        public void Draw()
        {
            Console.WriteLine("Малюємо лінійний графік.\n");

            DrawLine(8); // Приклад графіку
            // Цей графік просто дуже стабільний ;)
        }

        private void DrawLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(); // Перехід на новий рядок після завершення лінії
        }
    }
}
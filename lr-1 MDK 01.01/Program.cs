using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_1_MDK_01._01
{
    class Program
    {
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    return value;
                }
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                int value = ReadInt(prompt);
                if (value > 0)
                {
                    return value;
                }
                Console.WriteLine("Значение должно быть больше нуля. Попробуйте снова.");
            }
        }
        static int ReadFishSize()
        {
            while (true)
            {
                Console.Write("Введите размер рыбок (1 — мелкие, 2 — средние, 3 — крупные): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int size) && size >= 1 && size <= 3)
                {
                    return size;
                }
                Console.WriteLine("Некорректный выбор. Введите 1, 2 или 3.");
            }
        }
        static double CalculateTotalVolume(int length, int width, int height)
        {
            
            return (length * width * height) / 1000.0;
        }
        static double CalculateUsableVolume(double totalVolume)
        {
            return totalVolume * 0.8;
        }
    }
}

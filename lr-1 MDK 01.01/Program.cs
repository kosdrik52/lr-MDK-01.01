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
        static void Main()
        {
            int length = ReadPositiveInt("Введите длину аквариума (см): ");
            int width = ReadPositiveInt("Введите ширину аквариума (см): ");
            int height = ReadPositiveInt("Введите высоту аквариума (см): ");
            int fishSize = ReadFishSize();
            double totalVolume = CalculateTotalVolume(length, width, height);
            double usableVolume = CalculateUsableVolume(totalVolume);
            int litersPerFish;
            if (fishSize == 1)
            {
                litersPerFish = 5;
            }
            else if (fishSize == 2)
            {
                litersPerFish = 10;
            }
            else
            {
                litersPerFish = 20;
            }
            int fishCount = (int)(usableVolume / litersPerFish);
            Console.WriteLine($"Объём аквариума: {totalVolume:0.##} л");
            Console.WriteLine($"Полезный объём: {usableVolume:0.##} л");
            Console.WriteLine($"Максимальное количество рыбок: {fishCount}");
        }
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
    }
}

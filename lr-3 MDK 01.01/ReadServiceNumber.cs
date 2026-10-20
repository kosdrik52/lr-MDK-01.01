using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static int ReadServiceNumber(int serviceCount)
    {
        while (true)
        {
            Console.Write("Введите номер услуги (0 — завершить): ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                continue;
            }

            if (number == 0)
            {
                return 0;
            }
            if (number < 1 || number > serviceCount)
            {
                Console.WriteLine(
                    $"Ошибка: введите номер от 1 до {serviceCount} или 0.");
                continue;
            }
            return number;
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static int ReadQuantity()
    {
        while (true)
        {
            Console.Write("Введите количество: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int quantity))
            {
                Console.WriteLine("Ошибка: введите целое число.");
                continue;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Ошибка: количество не может быть отрицательным.");
                continue;
            }

            return quantity;
        }
    }
}

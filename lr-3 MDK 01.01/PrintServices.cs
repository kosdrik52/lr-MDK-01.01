using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static void PrintServices(List<Service> services)
    {
        Console.WriteLine("Услуги компьютерного клуба:");

        for (int i = 0; i < services.Count; i++)
        {
            Service service = services[i];

            Console.WriteLine(
                $"{i + 1}. {service.Name} — {service.Price} руб. " +
                $"(в наличии: {service.Stock})");
        }

        Console.WriteLine("\nВведите 0, чтобы завершить ввод заказа.");
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Service> services = CreateServices();
            PrintServices(services);
            List<OrderItem> order = ReadOrder(services.Count);
            if (TryProcessOrder(
                    services,
                    order,
                    out decimal total,
                    out string unavailableService))
            {
                Console.WriteLine($"\nЗаказ принят. Стоимость: {total} руб.");
            }
            else
            {
                Console.WriteLine(
                    $"\nЗаказ не принят: недостаточно услуги «{unavailableService}».");
            }
            PrintRemainingStock(services);
        }
    }
}

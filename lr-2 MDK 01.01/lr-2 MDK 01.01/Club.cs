using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_2_MDK_01._01
{
    internal class Club
    {
        public Service[] Services =
    {
        new Service("Компьютер", 100, 10),
        new Service("Печать", 15, 50),
        new Service("Наушники", 50, 5)
    };

        public void ShowServices()
        {
            for (int i = 0; i < Services.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {Services[i].Name} — {Services[i].Price} руб.");
            }
        }

        public void BuyService(int number, int quantity)
        {
            Service service = Services[number - 1];

            if (quantity > service.Stock)
            {
                Console.WriteLine("Недостаточно в наличии.");
                return;
            }

            service.Stock -= quantity;
            Console.WriteLine($"Стоимость: {service.Price * quantity} руб.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static void PrintRemainingStock(List<Service> services)
    {
        Console.WriteLine("\nОстатки услуг:");

        for (int i = 0; i < services.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {services[i].Name} — {services[i].Stock}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static bool TryProcessOrder(
         List<Service> services,
         List<OrderItem> order,
         out decimal total,
         out string unavailableService)
    {
        total = 0;
        unavailableService = string.Empty;

        // Суммируем количество каждой услуги в заказе.
        int[] requestedQuantities = new int[services.Count];

        foreach (OrderItem item in order)
        {
            requestedQuantities[item.ServiceIndex] += item.Quantity;
        }

        // Проверяем, хватает ли каждой услуги.
        for (int i = 0; i < services.Count; i++)
        {
            if (requestedQuantities[i] > services[i].Stock)
            {
                unavailableService = services[i].Name;
                return false;
            }
        }

    }

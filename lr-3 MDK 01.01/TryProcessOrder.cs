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

      
        int[] requestedQuantities = new int[services.Count];

        foreach (OrderItem item in order)
        {
            requestedQuantities[item.ServiceIndex] += item.Quantity;
        }

   
        for (int i = 0; i < services.Count; i++)
        {
            if (requestedQuantities[i] > services[i].Stock)
            {
                unavailableService = services[i].Name;
                return false;
            }
        }
        for (int i = 0; i < services.Count; i++)
        {
            services[i].Stock -= requestedQuantities[i];
            total += services[i].Price * requestedQuantities[i];
        }

        return true;

    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    private static List<OrderItem> ReadOrder(int serviceCount)
    {
        List<OrderItem> order = new List<OrderItem>();

        while (true)
        {
            int serviceNumber = ReadServiceNumber(serviceCount);
            if (serviceNumber == 0)
            {
                break;
            }

            int quantity = ReadQuantity();
            order.Add(new OrderItem(serviceNumber - 1, quantity));
        }
        return order;
    }

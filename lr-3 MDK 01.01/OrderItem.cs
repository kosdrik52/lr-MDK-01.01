using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3_MDK_01._01
{
    internal class OrderItem
    {
        public int ServiceIndex { get; }
        public int Quantity { get; }

        public OrderItem(int serviceIndex, int quantity)
        {
            ServiceIndex = serviceIndex;
            Quantity = quantity;
        }
    }
}

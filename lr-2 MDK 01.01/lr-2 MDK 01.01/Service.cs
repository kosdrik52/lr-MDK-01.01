using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_2_MDK_01._01
{
    internal class Service
    {
        public string Name;
        public decimal Price;
        public int Stock;

        public Service(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}

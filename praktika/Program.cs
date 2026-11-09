using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product basicProduct = new Product();
            basicProduct.SetName("Обычный товар (без скидки)");
            basicProduct.SetPrice(1000m);
            basicProduct.SetSoldcount(10); 
            products.Add(basicProduct);

            Sport_Eat food1 = new Sport_Eat();
            food1.SetName("Спортивное питание (батончик)");
            food1.SetPrice(150m);
            food1.SetSoldcount(7); // 5-10 единиц -> скидка 15%
            products.Add(food1);
        }
    }
}

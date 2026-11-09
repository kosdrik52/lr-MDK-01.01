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
            basicProduct.SetPrice(1000);
            basicProduct.SetSoldcount(10); 
            products.Add(basicProduct);

            Sport_Eat food1 = new Sport_Eat();
            food1.SetName("Спортивное питание (батончик)");
            food1.SetPrice(150);
            food1.SetSoldcount(7); 
            products.Add(food1); 
            
            Sport_Eat food2 = new Sport_Eat();
            food2.SetName("Спортивное питание (протеин)");
            food2.SetPrice(3000);
            food2.SetSoldcount(12); 
            products.Add(food2);

            Sport_Invent inv1 = new Sport_Invent();
            inv1.SetName("Инвентарь (гантели)");
            inv1.SetPrice(500);
            inv1.SetSoldcount(50); 
            products.Add(inv1);

            Sport_Invent inv2 = new Sport_Invent();
            inv2.SetName("Инвентарь (штанга)");
            inv2.SetPrice(10000);
            inv2.SetSoldcount(200); 
            products.Add(inv2);
        }
    }
}

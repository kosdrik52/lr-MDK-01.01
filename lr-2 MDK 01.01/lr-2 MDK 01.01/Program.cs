using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_2_MDK_01._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();

            club.ShowServices();

            Console.Write("Выберите услугу: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите количество: ");
            int quantity = int.Parse(Console.ReadLine());

            club.BuyService(number, quantity);
        }
    }
}

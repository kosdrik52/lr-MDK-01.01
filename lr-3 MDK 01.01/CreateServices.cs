using System;
using System.Collections.Generic;


namespace lr_3_MDK_01._01
{
    private static List<Service> CreateServices()
    {
        return new List<Service>
        {
            new Service("Час игры", 150, 20),
            new Service("Ночные часы", 120, 15),
            new Service("Выделенный компьютер", 300, 10),
            new Service("Печать страницы", 40, 30),
            new Service("Место в VIP-зоне", 400, 8)
        };
    }
}

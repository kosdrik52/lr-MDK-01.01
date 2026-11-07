using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Sport_Eat : Product 
    {
        public override int CalculateDiscount()
        {
            if (soldcount_ >= 5 && soldcount_ <= 10)
                return 15;
            if (soldcount_ > 10)
                return 25;
            return 0;
        }
    }
}

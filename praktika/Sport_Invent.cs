using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Sport_Invent : Product
    {
        public override int CalculateDiscount()
        {
            if (soldcount_ >= 20 && soldcount_ < 150)
                return 10;
            if (soldcount_ >= 150 && soldcount_ <= 300)
                return 30;
            if (soldcount_ > 300)
                return 50;
            else return 0;
        }
    }
}

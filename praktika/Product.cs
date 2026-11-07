using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Product
    {
        protected string name_;
        protected decimal price_;
        protected int soldcount_;     
     
    public string GetName()
        {
            return name_;
        }
        public void SetName( string value )
        {
          name_ = value;
        }
        public decimal GetPrice()
        {
            return price_;
        }
        public void SetPrice(decimal value) 
        {
            price_ = value;
        }
        public int GetSoldcount()
        { 
        return soldcount_;
        }
        public void GetSoldcount(int value)
        {
            soldcount_ = value;
        }
        public virtual int CalcuateDiscount()
        {
            return 0;
        }
        ,
    }
    
}

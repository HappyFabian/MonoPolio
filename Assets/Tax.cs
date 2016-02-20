using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestClass
{
    public class Tax : Space
    {
        int Price { get; set; }
        public Tax(String name, int price)
        {
            Name = name;
            Price = price;
        }

        public override void Action()
        {
            
        }
    }
}

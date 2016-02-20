using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestClass
{
    public class Utility : Space
    {
        public int Price { get; set; }

        public Utility(String name)
        {
            Name = name;
        }

        public override void Action()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyTestClass
{
    public abstract class Space
    {
        public String Name { get; set; }
        abstract public void Action();
    }
}

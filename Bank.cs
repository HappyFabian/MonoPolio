using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Classes
{
    class Bank
    {
        int _InitialMoney = 1500;
        public void AssignMoneytoPlayer(Player playerx)
        {
            playerx.AddMoney(_InitialMoney);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class Player
    {
        private int Location { get; set; }
        private int Money { get; set; }
        private bool Imprisoned { get; set; }


        void MoveLocation(int spaces)
        {
            this.Location += spaces;
        }

        void AddMoney(int amount)
        {
            this.Money += amount;
        }

        void SubMoney(int amount)
        {
            this.Money -= amount;   
        }

        void FreeFromPrison()
        {
            this.Imprisoned = false;
        }

        void Imprison()
        {
            this.Imprisoned = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


[Serializable]
public class Street : Space
{
    public int Price { get; set; }
    public int Rent { get; set; }

    public Street(String name)
    {
        Name = name;
    }

    public override void Action()
    {
            
    }
}


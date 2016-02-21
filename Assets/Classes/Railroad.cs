using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Railroad : Space
{
    public int Price { get; set; }
    public int Rent { get; set; }

    public Railroad(String name)
    {
        Name = name;
    }

    public override void Action()
    {
            
    }
}


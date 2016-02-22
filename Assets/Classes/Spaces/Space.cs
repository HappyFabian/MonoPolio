using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public class Space
{
    public Transform spot;
    public int Location;
    [SerializeField]
    public String Name { get; set; }
    public virtual void Action() {
        Debug.Log("WHAT");
    }

}


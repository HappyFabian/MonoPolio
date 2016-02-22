using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public class Player : MonoBehaviour
{

    [SerializeField]
    public int Location { get; set; }

    [SerializeField]
    public int Money { get; set; }

    [SerializeField]
    public bool Imprisoned { get; set; }

    [SerializeField]
    public string Name { get; set; }

    public SpriteRenderer PlayerIcon = new SpriteRenderer();

    public void setPlayer(int InitialLocation, int InitialMoney, string Name, Sprite Prefab, Color colour)
    {
        Location = InitialLocation;
        Money = InitialMoney;
        this.Name = Name;
        PlayerIcon.sprite = Prefab;
        PlayerIcon.color = colour;
    }

    public void UpdateLocation(int newLocation)
    {
        this.Location += newLocation;
        if (this.Location >= 40)
        {
            var offset = Location - 39;
            this.Location = offset;
        }
        Debug.Log(Location);
    }

    public void AddMoney(int amount)
    {
        this.Money += amount;
    }

    public void SubMoney(int amount)
    {
        this.Money -= amount;
    }

    public void FreeFromPrison()
    {
        this.Imprisoned = false;
    }

    public void Imprison()
    {
        this.Imprisoned = true;
    }
}


using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Dice_Manager : MonoBehaviour {

    public List<SpriteRenderer> Dices;
    public List<Sprite> Sides;

    public int HowManySpaces;
    public bool WasDouble;
    
    public void Roll_Dice()
    {
        var SideA = Random.Range(1, 7);
        var SideB = Random.Range(1, 7);

        Dices[0].sprite = Sides[SideA-1];
        Dices[1].sprite = Sides[SideB-1];

        HowManySpaces = SideA + SideB;

        if (SideA == SideB)
        {
            WasDouble = true;
        }
        else
        {
            WasDouble = false;
        }

    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_OptionsManager : MonoBehaviour
{
    public List<SelectedPlayer> SelectedPlayers;


    public bool VerifyPlayersRules()
    {
        int PlayerCount = 0;
        foreach(var sPlayer in SelectedPlayers)
        {
            if(sPlayer.Selected.isOn)
            {
                PlayerCount++;
            }
        }

        if (PlayerCount < 2)
            return false;
        else
            return true;
    }
}

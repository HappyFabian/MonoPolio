using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_OptionsManager : MonoBehaviour
{
    public List<SelectedPlayer> AvailablePlayers;
    public List<GameObject> SelectedPlayers;
    public Sprite Default_Sprite;
    public GameObject Player_Prefab;

    public bool inGame = false;

    public void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public bool VerifyPlayersRules()
    {

        foreach(GameObject obj in SelectedPlayers)
        {
            Destroy(obj);
        }

        int PlayerCount = 0;
        SelectedPlayers = new List<GameObject>();
        foreach(var sPlayer in AvailablePlayers)
        {
            if(sPlayer.Selected.isOn)
            {
                PlayerCount++;
                Color colour = Color.black;
                switch(sPlayer.Name)
                {
                    case "Red":
                        colour = Color.red;
                        break;
                    case "Yellow":
                        colour = Color.yellow;
                        break;
                    case "Green":
                        colour = Color.green;
                        break;
                    case "Blue":
                        colour = Color.blue;
                        break;
                }


                
                var playerObject = Instantiate(Player_Prefab);
                playerObject.gameObject.name = sPlayer.Name;
                playerObject.GetComponent<Player>().setPlayer(0, 1500, sPlayer.Name, Default_Sprite, colour);
                DontDestroyOnLoad(playerObject.gameObject);
                SelectedPlayers.Add(playerObject);
            }
        }

        if (PlayerCount < 2)
            return false;
        else
            return true;
    }


}

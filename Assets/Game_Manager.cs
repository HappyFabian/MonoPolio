using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Game_Manager : MonoBehaviour {

    bool GameisOn;
    public Board gameBoard;
    public Button Roll_Dice_Button;
    public Button End_Turn;
    public Dice_Manager diceManager;
    public List<GameObject> Players;

    public int CurrentPlayer = 0;
 
    void OnLevelWasLoaded()
    {
        var holder = GameObject.Find("Holder");
        Players = holder.GetComponent<Game_OptionsManager>().SelectedPlayers;
        GameisOn = true;
        foreach(GameObject player in Players)
        {
            Vector3 offset = new Vector3(Random.Range(-0.25f, 0.25f), Random.Range(-0.35f, 0.35f));
            Vector3 positionNew = gameBoard.BoardSpaces[0].spot.position;
           player.gameObject.transform.position = positionNew + offset; 
        }
        Destroy(holder);


    }
    
    public void StartTurn()
    {
        Roll_Dice_Button.interactable = true;
    }

    public void MovePlayer()
    {

        Roll_Dice_Button.interactable = false;
        End_Turn.interactable = true;
        var currentPlayerObject = Players[CurrentPlayer].GetComponent<Player>();
        currentPlayerObject.UpdateLocation(diceManager.HowManySpaces);
        Players[CurrentPlayer].transform.position = gameBoard.BoardSpaces[currentPlayerObject.Location].spot.position;
        Roll_Dice_Button.transform.gameObject.SetActive(true);
        
    }

    public void EndTurn()
    {
        End_Turn.interactable = false;
        if (!diceManager.WasDouble)
        {
            CurrentPlayer++;
            if(CurrentPlayer == Players.Count)
            {
                CurrentPlayer = 0;
            }
            StartTurn();
        }
        else
        {
            StartTurn();
        }
    }

}

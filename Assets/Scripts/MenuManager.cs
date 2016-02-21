using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour {

    public List<Transform> MenuPanels;
    public Game_OptionsManager Manager;
    public Transform Error_Dialog;

    public void LoadGameScene(string name)
    {
        if(Manager.VerifyPlayersRules())
        {

            SceneManager.LoadScene(name);
        }
        else
        {
            Error_Dialog.gameObject.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ToggleMenu(string name)
    {
        MenuPanels.ForEach
        (
            delegate (Transform menu) 
            {
                menu.gameObject.SetActive(false);
            }
        );
        MenuPanels.Find(
            delegate(Transform menu)
            {
                return menu.name == name;
            }
        ).gameObject.SetActive(true);
    }
}

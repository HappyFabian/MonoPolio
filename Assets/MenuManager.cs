using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour {

    public List<Transform> MenuPanels;

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
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

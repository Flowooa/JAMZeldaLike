using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal: MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene("MenuD�part 1");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}


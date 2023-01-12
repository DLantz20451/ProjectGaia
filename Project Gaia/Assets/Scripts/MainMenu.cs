using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //this is what the start button does when pressed
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    //this is what the start button does when pressed
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    //and respectfully this is the quit buttons actions
    public void QuitGame()
    {
        Application.Quit();
    }

    //restarts game and returns to main menu
    public void ExitButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

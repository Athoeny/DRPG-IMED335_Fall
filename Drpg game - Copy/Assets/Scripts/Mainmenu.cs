using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Hub World");
    }
    public void QuitGame()
    {
        Application.Quit();
    }


    public void ClickToHome()
    {
        SceneManager.LoadScene("Main Menu");
    }

   
}
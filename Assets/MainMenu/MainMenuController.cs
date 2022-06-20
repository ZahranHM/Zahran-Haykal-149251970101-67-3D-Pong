using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OpenHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void Exit()
    {
        //exit
    }

    public void Author()
    {
        Debug.Log("Created By Zahran Haykal - 149251970101-67");
    }
}
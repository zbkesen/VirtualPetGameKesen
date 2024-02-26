using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//////////////////////////////////////////////
//Assignment/Lab/Project: Virtual Pet
//Name: Zarek Kesen
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 02/26/2024
/////////////////////////////////////////////

public class UIController : MonoBehaviour
{
    public void OnClickQuitButton()
    {
        Debug.Log("Quit button clicked.");
        Application.Quit();
    }

    public void OnClickPlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickAdoptNewButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}

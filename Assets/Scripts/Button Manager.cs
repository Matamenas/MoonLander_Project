using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Moon");
    }

     public void Openurl(){

    Application.OpenURL("https://github.com/Matamenas/MoonLander_Project");
    }

    public void Exitgame(){
        Application.Quit();
        Debug.Log("ur mom");
        }
}

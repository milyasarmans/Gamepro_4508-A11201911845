using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void StartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Play() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayAgain() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void NextLevel() 
    {
        SceneManager.LoadScene("NextLevel");
    }
    public void Credit() 
    {
        SceneManager.LoadScene("Credit");
    }
    public void Help() 
    {
        SceneManager.LoadScene("Help");
    }
}

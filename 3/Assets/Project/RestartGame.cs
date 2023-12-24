using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject Pannel;
    
    public void LevelChange()
    {
        {
            Debug.Log("Button pressed");
            Pannel.SetActive(false);
            SceneManager.LoadScene("MainScene");
        }
    }

    public void ExitGame()
    {
        Debug.Log("ByeBye");
        Application.Quit();
    }
}
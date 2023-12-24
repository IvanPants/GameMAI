using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinGame : MonoBehaviour, IInteractable
{
    public GameObject panel;
    public bool switcher = false;
    
    private void Start()
    {
         panel.SetActive(switcher);   
    }

    public string GetDescription()
    {
        if (switcher) return "press e";
        return "press e";
    }
    public void Interact()
    {
        switcher = !switcher;
        // panel.SetActive(switcher);
        SceneManager.LoadScene("FinalScene");
    }
}

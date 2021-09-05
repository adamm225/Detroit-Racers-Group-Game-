using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeyboard : MonoBehaviour
{
    public static bool curPaus = false;
    public GameObject pauseMenu;
    public GameObject mainScreen;
    void Start()
    {
        
    }

        void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("pressed");
            if (curPaus){
                Resume();
            } else {
                Pause();
            }
        }
    }
    void Resume(){
        pauseMenu.SetActive(false);
        mainScreen.SetActive(true);
        Time.timeScale = 1f;
        curPaus = false;
    }
    void Pause(){
        pauseMenu.SetActive(true);
        mainScreen.SetActive(false);
        Time.timeScale = 0f;
        curPaus = true;
    }
}
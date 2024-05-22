using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   public static bool GameIsPaused = false;
   public GameObject pauseMenuUI;
   public GameObject inventoryMenuUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!GameIsPaused) Pause();
            else Resume();
        }
    }
    public void Resume(){
        pauseMenuUI.SetActive(false);
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

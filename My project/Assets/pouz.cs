using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pouz : MonoBehaviour
{
    public static bool GameIsPauz = false;
    public GameObject pauseMenuUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPauz)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPauz = false;

    }
    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPauz = true; 
    }
}

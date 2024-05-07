using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject instructions;


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
    }

    public void Play()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Guide()
    {
        instructions.SetActive(!instructions.activeSelf);
        pauseMenu.SetActive(false);
    }

    public void ExitGuide()
    {
        instructions.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



}

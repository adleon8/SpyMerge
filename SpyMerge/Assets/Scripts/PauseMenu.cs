using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject instructions;
    [SerializeField] InventoryObject inventory;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
        }
        
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
        inventory.Container.Clear();
    }

    public void Play()
    {
        pauseMenu.SetActive(false);
        if (!pauseMenu.activeSelf)
        {
            Time.timeScale = 1;
        }
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
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0;
            Debug.Log("No run");

        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("Time run");
        }
        inventory.Container.Clear();

    }



}

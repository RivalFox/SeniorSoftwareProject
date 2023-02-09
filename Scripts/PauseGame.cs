using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject rulesScreenUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseScreen();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        rulesScreenUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }
    public void PauseScreen()
    {
        pauseMenuUI.SetActive(true);
        rulesScreenUI.SetActive(false);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void RulesScreen()
    {
        pauseMenuUI.SetActive(false);
        rulesScreenUI.SetActive(true);
        isPaused = true;
        Time.timeScale = 0f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    // public void GoToRulesScreen()
    // {
    //     pauseMenuUI.SetActive(false);

    //     //Changes the scene and saves the data into the gameData.txt
    //     GameManager.ChangeScene(SceneManager.GetActiveScene().name);

    //     SceneManager.LoadScene("Rules Scene(Jarel)");
    // }
}
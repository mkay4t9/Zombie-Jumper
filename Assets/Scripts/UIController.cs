using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static bool gameOver;
    public GameObject resumePannel;
    public GameObject gameOverPannel;

    private void Start() {
        gameOver = false;
    }

    private void Update() {
        if (gameOver)
        {
            gameOverPannel.SetActive(true);
        }
    }
    public void RestartGame()
    {
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        resumePannel.SetActive(true);
        
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        resumePannel.SetActive(false);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

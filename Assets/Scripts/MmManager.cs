using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MmManager : MonoBehaviour
{
    public GameObject quitpannel;

    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quitgame()
    {
        quitpannel.SetActive(true);
    }
    public void yes()
    {
        Application.Quit();
    }
    public void no()
    {
        quitpannel.SetActive(false);
    }
}

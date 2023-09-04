using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    int score = 0;
    int highscore = 0;

    void Awake() {
        instance = this;    
    }
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score : " + score.ToString();
        highscoreText.text = "HighScore : " + highscore.ToString();
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 1;
        scoreText.text = "Score : " + score.ToString();
        if(highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}

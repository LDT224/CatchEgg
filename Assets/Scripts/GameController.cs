using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject pnlLose;
    public Text txtScore;
    public Text txtHighScore;
    private int score;
    public AudioSource getPointSound;
    public AudioSource loseSound;
    public AudioSource shitSound;
    // Start is called before the first frame update
    void Start()
    {
        //Display Highscore
        if(PlayerPrefs.GetInt("HighScore", 0) == 0)
        {
            txtHighScore.text = "Highscore: 0";
        }
        else
        {
        txtHighScore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
    public void GetPoint()
    {
        //+ score, play get point sound
        score++;
        txtScore.text = "Score: " + score.ToString();
        getPointSound.Play();
        //Update highscore
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            txtHighScore.text = "HighScore: " + score.ToString();
        }
    }
    public void menuScene()
    {
        //Unpause, load menu scene
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void difficultyScene()
    {
        //Unpause, load difficulty scene
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void gameScene()
    {
        //Unpause, load game scene
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void lose()
    {
        //Pause game, play lose sound, active lose panel
        loseSound.Play();
        Time.timeScale = 0;
        pnlLose.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

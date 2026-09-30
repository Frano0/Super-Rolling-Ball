using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public PlayerSphere player;
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public TMP_Text gameOverText;
    public TMP_Text winText;
    public float scoreWeight;
    private float timer = 0f;
    public string menuSceneName = "Main Menu";
    private System.Boolean finalTimeCalculated;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverText.enabled = false;
        winText.enabled = false;
        scoreWeight = 1.0f;
        finalTimeCalculated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameOver == false && player.isWin == false)
        {
            timer += Time.deltaTime;
            timerText.text = "Time : " + Mathf.Round(timer * 100.0f) * 0.01f;
        }
        else if (player.isWin)
        {
            if (finalTimeCalculated == false)
            {
                timer -= player.score * scoreWeight;
                winText.text = "You won !\nYour final time : " + Mathf.Round(timer * 100.0f) * 0.01f;
                winText.enabled = true;
                finalTimeCalculated = true;
            }
        }
            
        else
        {
            gameOverText.enabled = true;
        }
        
        scoreText.text = "Score: " + player.score;
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

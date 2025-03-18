using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scare : MonoBehaviour
{
    public int score = 0;
    public float timer = 0f;
    public float timerRate = 1f;
    public int highScore = 0;

    public Text ScoreDisplay;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;

        if (timer >= 1f)
        {
            score++;
            ScoreDisplay.text = "Score: " + score; 
            timer = 0f;

            if (score > highScore) highScore = score;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private int mouthPoints = 0;
    public Text mouthText;
    public Text scoreText;
    public GameObject winText;
    public GameObject loseText;
    public GameObject restartButton;
    public GameObject spoonOBJ;

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Fails: " + score;
    }

    public void MouthScore(int value)
    {
        mouthPoints += value;
        mouthText.text = "Feeded: " + mouthPoints;
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        if (score + mouthPoints >= 10)
        {
            spoonOBJ.SetActive(false);
            restartButton.SetActive(true);

            if (score > mouthPoints)
            {
                loseText.SetActive(true);
            }

            if (score < mouthPoints)
            {
                winText.SetActive(true);
            }
        }
    }
}

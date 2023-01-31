using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private int mouthPoints = 0;
    public Text mouthText;
    public Text scoreText;
    public GameObject restartButton;

    private void Start()
    {
        Button restartButton = gameObject.AddComponent<Button>();
        restartButton.onClick.AddListener(OnClick);
    }

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

    public void OnClick()
    {
        mouthPoints = 0;
        score = 0;
        restartButton.SetActive(false);
    }

    private void Update()
    {
        if (score + mouthPoints >= 10)
        {
            restartButton.SetActive(true);
        }
    }
}

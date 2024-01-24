using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Manager : MonoBehaviour
{
   
    public int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        
        UpdateScoreText();

    }

    public void UpdateScoreText()
    {
        
        scoreText.text = "" + score;

    }

    public void IncraseScoretect(int amount)
    {

        score += amount;
        UpdateScoreText();

    }
}

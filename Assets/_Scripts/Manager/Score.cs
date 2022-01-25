using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int score;

    void Start()
    {
        score = 0;
    }

    //updates the text in the textMeshProUGUI object
    public virtual void changeText(int score)
    {
        text.text = "Score: " + score.ToString();
    }
    public void updateScore(int val)
    {
        score += val;
        changeText(score);
    }
    public void resetScore()
    {
        score = 0;
        changeText(score);
    }
}

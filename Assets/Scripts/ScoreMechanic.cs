using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMechanic : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

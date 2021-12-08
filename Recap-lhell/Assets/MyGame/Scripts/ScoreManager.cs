using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    private Text score;
    public GameObject winText;

    public void Start()
    {
        score = GetComponent<Text>();
    }

    public void Update()
    {
        score.Text = "Score: " + scoreValue;

        if (scoreValue == 10)
        {
            winText.gameObject.Setactive = true;
        }
    }
}

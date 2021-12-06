using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreText;
    private int score;

    public GameObject winText;
    public GameObject target;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = ("Score: "+ score);

        if(Input.GetMouseButtonDown(0)) 
        {
            score += 1;
            DestroyImmediate(target, true);
        }
        if (score == 10)
        {
            winText.SetActive(true);
        }
    }
}

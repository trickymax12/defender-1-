using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void UpdateScore()
    {
        ScoreDisplay.text = $"Score: {score}";
    }
    public void AddScore(int AmountToAdd)
    {
        score += AmountToAdd;
        UpdateScore();
    }
}

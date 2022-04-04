using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


//Setting Up Some Score Value When Player Collected The Keys...
public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

     [SerializeField]  private int score = 0;

    private void Awake() {
       scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start() {
        RefreshUI();
    }

    public void IncScore(int ScoreIncrementer){
        score += ScoreIncrementer;
        RefreshUI();
    } 

    public void RefreshUI() {
        scoreText.text = "Score : " +score;
    }

}

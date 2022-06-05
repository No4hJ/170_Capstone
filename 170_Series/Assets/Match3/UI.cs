using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public level level;

    public UnityEngine.UI.Text timeText;
    public UnityEngine.UI.Text targetText;
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text finalscore;
    
    
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalscore.text = "Your " +  scoreText.text;
    }

    public void SetScore(int score){
        scoreText.text = "Score: " + score.ToString();
    }
    public void SetTarget(int target){
        targetText.text = "Highest Score: " + target.ToString();
    }

    public void SetRemaining(string remaining){
        timeText.text = "Time: " + remaining;
    }
    public void OnGameWin(int score){
        isGameOver = true;
    }

    public void OnGameLose(){
        isGameOver = true;
    }


}

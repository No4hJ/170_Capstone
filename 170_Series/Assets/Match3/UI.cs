using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public level level;

    public UnityEngine.UI.Text timeText;
    public UnityEngine.UI.Text targetText;
    public UnityEngine.UI.Text scoreText;
    
    private int starIdx = 0;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScore(int score){
        scoreText.text = score.ToString();
    }
    public void SetTarget(int target){
        targetText.text = target.ToString();
    }

    public void SetRemaining(string remaining){
        timeText.text = remaining;
    }

    public void OnGameWin(int score){
        isGameOver = true;
    }

    public void OnGameLose(){
        isGameOver = true;
    }


}

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
    
    private float myScore = 0;
    private float newScore;
    private int lastscore;

    private bool isGameOver = false;
    public float t1;
    [SerializeField][Range(0,5)]float totalTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t1+= totalTime * Time.deltaTime;

        myScore = Mathf.Lerp(myScore, newScore,t1 );

        if(newScore - myScore < 1){
            myScore = newScore;
        }

        scoreText.text = "Score: " + Mathf.FloorToInt(myScore).ToString();
        finalscore.text = "Your " +  scoreText.text;
    }

    public void SetScore(int score){
        newScore = score;

        t1 = 0;
        //scoreText.text = "Score: " + score.ToString();
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

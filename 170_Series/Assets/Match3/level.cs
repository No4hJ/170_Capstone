using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    public enum LevelType
    {
        TIMER,
        OBSTACLE,
        MOVES,
    };


    public Gridline grid;
    public int score1Star;
    public int score2Star;
    public int score3Star;

    protected LevelType type;

    public LevelType Type{
        get { return type;}
    }

    protected int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void GameWin(){
        Debug.Log("win");
        grid.GameOver();
    }

    public virtual void GameLose(){
        Debug.Log("Lose");
        grid.GameOver();
    }

    public virtual void OnMove(){
        Debug.Log("onmove");
    }

    public virtual void OnPieceCleared(GamePiece piece){
        currentScore += piece.score;
        Debug.Log("Score: " + currentScore);
    }
}

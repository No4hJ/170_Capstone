using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public UI UI;
    protected LevelType type;

    public GameObject Lose;

    public LevelType Type{
        get { return type;}
    }

    //protected int currentScore;
    public int currentScore;
    
    // Start is called before the first frame update
    void Start()
    {
        UI.SetScore(currentScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void GameWin(){
        Debug.Log("win");
        SceneManager.LoadScene("ENDScene");
        UI.OnGameWin(currentScore);
        grid.GameOver();

    }

    public virtual void GameLose(){
        Debug.Log("Lose");

        Lose.SetActive(true);

        //UI.OnGameLose();
        //grid.GameOver();
    }

    public virtual void OnMove(){
        Debug.Log("onmove");
    }

    public virtual void OnPieceCleared(GamePiece piece){
        currentScore += piece.score;
        UI.SetScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

    public virtual void PlayAgain(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

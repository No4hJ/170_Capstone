using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : level
{
    public int timeInseconds;
    public int targetScore;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.TIMER;
        Debug.Log("Time:" + timeInseconds + "second. Target score: " + targetScore);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timeInseconds - timer <= 0 ){
            if(currentScore >= targetScore){
                GameWin();
            }else{
                GameLose();
            }
        }
    }
}

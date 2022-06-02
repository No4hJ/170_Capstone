using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : level
{
    public int timeInseconds;
    public int targetScore;
    
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.TIMER;
        Debug.Log("Time:" + timeInseconds + "second. Target score: " + targetScore);
        
        
        UI.SetScore(currentScore);
        UI.SetTarget(targetScore);
        UI.SetRemaining(string.Format("{0}:{1:00}", timeInseconds/60, timeInseconds%60));

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        UI.SetRemaining(string.Format("{0}:{1:00}", (int)Mathf.Max((timeInseconds - timer)/60,0), (int)Mathf.Max((timeInseconds - timer)%60,0)));

        if(timeInseconds - timer <= 0 ){
            if(currentScore >= targetScore){
                GameWin();
            }else{
                GameLose();
            }
        }

        if(currentScore >= targetScore){
                GameWin();
        }
    }
}

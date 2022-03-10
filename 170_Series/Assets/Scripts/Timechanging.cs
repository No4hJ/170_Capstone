using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timechanging : MonoBehaviour
{
    public float Day;
    public float REAL_SECONDS_PER_INGAME_DAY = 1000f;

    private static float timeSet = 3.0f; // Set Wait Time Here!
    private float moveTime = timeSet;

    public AudioSource clock_sound;
    public GameObject clock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!MenuControl.isPaused){
            Time.timeScale = 1f;
            Day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;
        } else {
            Day += 0;
            Time.timeScale = 0f;
        }
        if(Input.GetKeyDown("u")){
            autoclock();
        }

        if (Global.person1ChatState == 1 && Global.person2ChatState == 1 && Global.clockState == 1){
            clock_sound.Stop();
            autoclock();
            moveTime -= Time.deltaTime;
            if (moveTime <= 0){
                Global.clockState = 2;
                clock.GetComponent<ClockUI>().autoclocktrigger = false;
            }
        }
    }

    private void autoclock(){
        clock.GetComponent<ClockUI>().autoclocktrigger = true;
    }

}

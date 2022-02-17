using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timechanging : MonoBehaviour
{
    public float Day;
    public float REAL_SECONDS_PER_INGAME_DAY = 1000f;
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
        Debug.Log(Day);
        Debug.Log(MenuControl.isPaused);
    }
}

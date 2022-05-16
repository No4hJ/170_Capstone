using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject tt;
    private static float waitTimeSet = 0.8f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;

    void Start()
    {
        tt = transform.Find("timeText").gameObject;
    } 

    // Update is called once per frame
    void Update()
    {
        string ttt = tt.GetComponent<Text>().text;
        if (ttt== " 11:30 PM"){ // here to change the time
            //Debug.Log("AAAA!!!!");
            waitTime -= Time.deltaTime;
            if (waitTime <= 0){
                Global.clockStateS2 = 1;
            }
        }
    }
}

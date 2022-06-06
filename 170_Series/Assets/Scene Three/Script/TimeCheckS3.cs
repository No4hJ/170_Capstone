using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheckS3 : MonoBehaviour
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
        if (ttt== " 03:23 PM"){ // here to change the time
            waitTime -= Time.deltaTime;
            if (waitTime <= 0){
                Global.clockStateS3 = 1;
            }
            //Debug.Log(Global.clockStateS3);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

    public GameObject clock;
    public float REAL_SECONDS_PER_INGAME_DAY;
    private Transform clockHourHandTransform;
    private Transform clockMinuteHandTransform;
    private Text timeText;
    public float day; 

    public bool autoclocktrigger = false;
    public bool clockchange = false;

    public bool clockstop = false;
    
    private void Awake() {
        clockHourHandTransform = transform.Find("hourHand");
        clockMinuteHandTransform = transform.Find("minuteHand");
        timeText = transform.Find("timeText").GetComponent<Text>();
    }

    private void Update() {
        REAL_SECONDS_PER_INGAME_DAY = GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY;
        day = GameObject.Find("Timescript").GetComponent<Timechanging>().Day;

        float dayNormalized = day % 1f;

        float rotationDegreesPerDay = 360f;
        clockHourHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay);

        float hoursPerDay = 12f;
        clockMinuteHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay * hoursPerDay);

        string hoursString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");

        float minutesPerHour = 60f;
        string minutesString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");

        //For check AM/PM
        int daynumber = (int)day;

        string APM;
        if ( daynumber % 2 == 0){
            APM = "AM";
        }else{
         APM = "PM";
        }

        //Debug.Log(daynumber);
        //timeText.text = "day " + daynumber/2 + "   " + hoursString + ":" + minutesString + " " + APM;
        timeText.text = " " + hoursString + ":" + minutesString + " " + APM;

        if(autoclocktrigger == false){
                if(day <= 0){
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = 1000f;
            }else if(day > 0 && Input.GetKey(KeyCode.D) && clockchange == true){
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = 5f;
            }else if(day > 0 && Input.GetKey(KeyCode.A) && clockchange == true){
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = -5f;
            }else if(day > 0 && Input.GetKey(KeyCode.E) && clockchange == true){
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = 50f;
            }else if(day > 0 && Input.GetKey(KeyCode.Q) && clockchange == true){
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = -50f;
            }else{
                if(clockstop){
                    GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = 999999f;
                    }else{
                        GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = 1000f;
                    }
                
                
            }
        }
        
        if(GameObject.Find("Clock") && autoclocktrigger){
            //Debug.Log("aaa");
            GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = Mathf.Lerp(
                GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY, 3f, 10* Time.deltaTime);
            
            
        }

        if (Global.person1ChatStateS2 ==1 && !clockchange){
            clockchange = true;
            clockstop = true;

        }

        if (Global.person1ChatStateS3 ==1 && !clockchange){
            clockchange = true;
            clockstop = true;
        }
    }

    public void autoclock(){
        autoclocktrigger = true;
    }
    private void changespeed(){
        GameObject.Find("Timescript").GetComponent<Timechanging>().REAL_SECONDS_PER_INGAME_DAY = Mathf.Lerp(1000f, 60f, 5* Time.deltaTime);
    }
}

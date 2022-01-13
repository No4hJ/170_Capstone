
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

    public GameObject clock;
    private float REAL_SECONDS_PER_INGAME_DAY = 2000f;

    private Transform clockHourHandTransform;
    private Transform clockMinuteHandTransform;
    private Text timeText;
    public float day;

    private void Awake() {
        clockHourHandTransform = transform.Find("hourHand");
        clockMinuteHandTransform = transform.Find("minuteHand");
        timeText = transform.Find("timeText").GetComponent<Text>();
    }

    private void Update() {
        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;

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
        timeText.text = "day " + daynumber/2 + "   " + hoursString + ":" + minutesString + " " + APM;

        if(Input.GetKey(KeyCode.A)){
            REAL_SECONDS_PER_INGAME_DAY = 60f;
        }else 
        if(Input.GetKey(KeyCode.D)){
            REAL_SECONDS_PER_INGAME_DAY = -60f;
        }else{
            REAL_SECONDS_PER_INGAME_DAY = 2000f;
        }
    }

}

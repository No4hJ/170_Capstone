using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_sound : MonoBehaviour
{
    public GameObject clock;
    public AudioSource clock_ticking;
    public AudioSource clock_stop;
    public bool isPlayed = false;

    // Update is called once per frame
    void Update()
    {
        if (clock.activeSelf){
            clock_ticking.volume = 0.2f;
            clock_ticking.spatialBlend = 0.3f;
            GameObject.Find("clock_ticking").GetComponent<AudioLowPassFilter>().cutoffFrequency = 22000f;
            GameObject.Find("clock_ticking").GetComponent<AudioHighPassFilter>().cutoffFrequency = 0f;
        }
        else{
            clock_ticking.volume = 0.6f;
            clock_ticking.spatialBlend = 0.8f;
            GameObject.Find("clock_ticking").GetComponent<AudioLowPassFilter>().cutoffFrequency = 1133f;
            GameObject.Find("clock_ticking").GetComponent<AudioHighPassFilter>().cutoffFrequency = 2400f;
        }

        if (Global.person1ChatState == 1 && Global.person2ChatState == 1)
        {   
            if(!isPlayed){
                Debug.Log("Play clock_stop sound");
                StartCoroutine(Stopsound());
                isPlayed = true;
            }
        }
    }

    IEnumerator Stopsound()
    {
        yield return new WaitForSeconds(0.8f);
        clock_stop.Play();
        clock_ticking.Stop();
    }
}

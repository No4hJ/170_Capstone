using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_sound_lvl2 : MonoBehaviour
{
    public GameObject clock;
    public AudioSource clock_ticking;
    public AudioSource clock_stop;
    public bool isPlayed2 = false;

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
            clock_ticking.volume = 0.3f;
            clock_ticking.spatialBlend = 0.8f;
            GameObject.Find("clock_ticking").GetComponent<AudioLowPassFilter>().cutoffFrequency = 1133f;
            GameObject.Find("clock_ticking").GetComponent<AudioHighPassFilter>().cutoffFrequency = 2400f;
        }

        if(Global.marriageCertificateState == 3)
        {
        if(!isPlayed2)
            {
            Debug.Log("PLAY!!!!!!!!!!");
            StartCoroutine(Stopsound());
            isPlayed2 = true;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_sound : MonoBehaviour
{
    public GameObject clock;
    public GameObject newspaper_big;
    public AudioSource clock_ticking;
    public AudioSource newspaper_open;
    // Update is called once per frame
    void Update()
    {
        if (clock.activeSelf){
            clock_ticking.volume = 0.8f;
            clock_ticking.spatialBlend = 0.3f;
        }
        else{
            clock_ticking.volume = 0.2f;
            clock_ticking.spatialBlend = 0.8f;
        }
    }
}

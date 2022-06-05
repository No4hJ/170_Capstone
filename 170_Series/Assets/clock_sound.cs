using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock_sound : MonoBehaviour
{
    public GameObject clock;
    public AudioSource clock_ticking;
    // Update is called once per frame
    void Update()
    {
        if (clock.activeSelf){
            clock_ticking.volume = 0.9f;
            clock_ticking.spatialBlend = 0.3f;
        }
        else{
            clock_ticking.volume = 0.6f;
            clock_ticking.spatialBlend = 0.8f;
        }

        if (Global.person1ChatState == 1 && Global.person2ChatState == 1)
        {
            clock_ticking.Stop();
        }
    }
}

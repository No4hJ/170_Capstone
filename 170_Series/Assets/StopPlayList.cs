using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayList : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject phone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.clockState >= 2){
            phone.GetComponent<Music_script>().MusicStop();
        }
        else if(Global.clockStateS2 >= 1){
            phone.GetComponent<Music_script>().MusicStop();
        }
        else if(Global.clockStateS3 > 2){
            phone.GetComponent<Music_script>().MusicStop();
        }

    }
}

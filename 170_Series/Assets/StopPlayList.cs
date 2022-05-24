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
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_sound_level3 : MonoBehaviour
{
    public AudioSource phoneSound;
    private bool isPlayed = false;

    // Update is called once per frame
    void Update()
    {
        if (Global.clockStateS3 == 1 && !isPlayed){
            //Debug.Log(Global.clockStateS3);
            //StartCoroutine(playphone());
            phoneSound.Play();
            isPlayed = true;
        }
    }

    // public IEnumerator playphone(){
    //     yield return new WaitForSeconds(0.0f);
    //     phoneSound.Play();
    // }
}

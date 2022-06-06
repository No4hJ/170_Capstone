using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_sound_level3 : MonoBehaviour
{
    public AudioSource phoneSound;

    // Update is called once per frame
    void Update()
    {
        if (Global.clockStateS3 == 1){
            StartCoroutine(playphone());
        }
    }

    public IEnumerator playphone(){
        yield return new WaitForSeconds(0.2f);
        phoneSound.Play();
    }
}

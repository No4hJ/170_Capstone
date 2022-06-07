using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_sound_level2 : MonoBehaviour
{
    public AudioSource phoneSound;

    // Update is called once per frame
    void Update()
    {
        if (Global.marriageCertificateState == 1){
            StartCoroutine(playphone());
            Global.marriageCertificateState =2;
        }
    }

    public IEnumerator playphone(){
        yield return new WaitForSeconds(0.5f);
        phoneSound.Play();
    }
}

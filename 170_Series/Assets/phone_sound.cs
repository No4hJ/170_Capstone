using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class phone_sound : MonoBehaviour
{
    public AudioSource phoneSound;

    // Update is called once per frame
    void Update()
    {
        if (Global.newspaperState == 1){
            StartCoroutine(playphone());
            Global.newspaperState = 2;
            Debug.Log("Play for news");
        }

        if (Global.ticketState == 1){
            StartCoroutine(playphone());
            Global.ticketState = 2;
            Debug.Log("Play for ticket");
        }
    }

    public IEnumerator playphone(){
        yield return new WaitForSeconds(0.5f);
        phoneSound.Play();
    }
}

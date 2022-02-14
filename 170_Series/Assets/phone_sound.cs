using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone_sound : MonoBehaviour
{
    public AudioSource phoneSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.newspaperState == 1){
            phoneSound.Play();
            Global.newspaperState = 2;
            Debug.Log("Play for news");
        }

        if (Global.ticketState == 1){
            phoneSound.Play();
            Global.ticketState = 2;
            Debug.Log("Play for ticket");
        }
    }
}

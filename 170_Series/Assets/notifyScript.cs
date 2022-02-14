using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notifyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.newspaperState == 2){
            gameObject.GetComponent<Renderer>().enabled = true;
            Global.newspaperState = 3;
        }

        if (Global.ticketState == 2){
            gameObject.GetComponent<Renderer>().enabled = true;
            Global.ticketState = 3;
        }
    }

}

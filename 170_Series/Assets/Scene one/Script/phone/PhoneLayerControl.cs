using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.newspaperState ==2||Global.ticketState ==2){
            GetComponent<SpriteRenderer>().sortingOrder = 50;
        }else{
            GetComponent<SpriteRenderer>().sortingOrder = 5;
        }
    }
}

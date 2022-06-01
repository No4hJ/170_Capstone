using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLayerControlS3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.clockStateS3 ==1){
            GetComponent<SpriteRenderer>().sortingOrder = 50;
        }else{
            GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
    }
}

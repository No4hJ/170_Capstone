using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLayerControlS2 : MonoBehaviour
{      
    public Sprite Bright;
    public Sprite Dark;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.marriageCertificateState == 1){
            GetComponent<SpriteRenderer>().sprite = Bright;
        }else{
            GetComponent<SpriteRenderer>().sprite = Dark;
        }
    }
}

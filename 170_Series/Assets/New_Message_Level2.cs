using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Message_Level2 : MonoBehaviour
{
    public GameObject red_dot1;
    // Update is called once per frame
    void Start()
    {
        red_dot1.SetActive(false);
    }
    void Update()
    {
        if(Global.marriageCertificateState == 2){
            red_dot1.SetActive(true);
        }else if(Global.marriageCertificateState >= 3){
            red_dot1.SetActive(false);
        }
    }
}

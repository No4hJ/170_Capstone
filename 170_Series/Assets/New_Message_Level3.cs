using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Message_Level3 : MonoBehaviour
{
    public GameObject red_dot1;
    // Update is called once per frame
    void Start()
    {
        red_dot1.SetActive(false);
    }
    void Update()
    {
        if(Global.clockStateS3 == 2){
            Debug.Log("red_dot_show");
            red_dot1.SetActive(true);
            Global.clockStateS3 = 3;
        } 
        if (Global.person1ChatStateS3 == 2){
            red_dot1.SetActive(false);
        }
    }
}

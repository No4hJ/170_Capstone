using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMessage : MonoBehaviour
{

    public GameObject red_dot1;
    public GameObject red_dot2;
    // Update is called once per frame
    void Start()
    {
        red_dot1.SetActive(false);
        red_dot2.SetActive(false);
    }
    void Update()
    {
        if(Global.ticketState == 2){
            red_dot1.SetActive(true);
            Global.ticketState = 3;
        }
        if(Global.person1ChatState == 1){
            red_dot1.SetActive(false);
        }

        if(Global.newspaperState == 2){
            red_dot2.SetActive(true);
            Global.newspaperState = 3;
        }
        if(Global.person2ChatState == 1){
            red_dot2.SetActive(false);
        }

    }
}

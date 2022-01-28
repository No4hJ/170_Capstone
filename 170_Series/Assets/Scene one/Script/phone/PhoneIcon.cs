using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneIcon : MonoBehaviour
{
    void OnMouseDown (){
        interaction();
    }
    private void interaction(){
        if(gameObject.name == "Chat"){
            Debug.Log("chat");
        }
    }
}

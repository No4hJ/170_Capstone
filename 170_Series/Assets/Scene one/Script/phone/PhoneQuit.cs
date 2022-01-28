using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneQuit : MonoBehaviour
{
    public GameObject phone;
    void OnMouseDown (){
        interaction();
    }

    void OnMouseEnter(){
        Debug.Log("phone");
    }
    private void interaction(){
        if(gameObject.name == "Back"){
            Debug.Log("phone");
            turnoffphone();
        }
    }

    private void turnoffphone(){
        phone.SetActive(false);
    }
}

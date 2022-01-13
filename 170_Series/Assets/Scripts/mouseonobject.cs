using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseonobject : MonoBehaviour
{   
    public GameObject clock;

    void OnMouseDown (){
        interaction();
    }

    private void interaction(){

        if(gameObject.name == "item 1"){
            Debug.Log("item 1");
            Debug.Log("NotAdded");
        }else if(gameObject.name == "item 2"){
            Debug.Log("item 2");
            Debug.Log("NotAdded");
        }else if(gameObject.name == "item 3"){
            Debug.Log("item 3");
            Debug.Log("NotAdded");
        }else if(gameObject.name == "item 4"){
            Debug.Log("time");
            clock.SetActive(true);
        }else{

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseonobject : MonoBehaviour
{   
    public GameObject clock;
    public GameObject CamButtonUI;
    void OnMouseDown (){
        interaction();
    }

    private void interaction(){
        
        if(gameObject.name == "item 1"){
            Debug.Log("Desk");

            changecamera("Camera_wardrobe");
        }else if(gameObject.name == "item 2"){
            Debug.Log("Coffee table");
            changecamera("Camera_coffee_table");
        }else if(gameObject.name == "item 3"){
            Debug.Log("Wardrobe");
            changecamera("Camera_wardrobe");
        }else if(gameObject.name == "item 4"){
            Debug.Log("Time");
            clock.SetActive(true);
        }else if(gameObject.name == "item 5"){
            Debug.Log("Calendar");
            changecamera("Camera_clendar");
        }else{

        }
    }

    //changecamera
    private void changecamera(string cam_name){
        GameObject cam_sending = GameObject.Find("Camera");
        cam_sending.GetComponent<Camback>().cam_name = cam_name;
        //Camera cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        Camera cam2 = GameObject.Find(cam_name).GetComponent<Camera>();
        //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
        cam2.enabled = true;
        CamButtonUI.SetActive(true);
        //aud2.enabled = true;
    }
}

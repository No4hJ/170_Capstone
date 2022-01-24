using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseonobject : MonoBehaviour
{
    public GameObject clock;
    public GameObject CamButtonUI;
    public float magnify = 1.15f;

    void OnMouseEnter(){
        effectOn();
    }

    void OnMouseDown (){
        interaction();
    }

    void OnMouseExit(){
        effectOff();
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

    private void effectOn(){
        //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.white);
        gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",1);
        //Change Scale
        Vector3 objScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
        //Debug.Log("effectOn");
    }

    private void effectOff(){
        gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",0);
        //Change Scale
        Vector3 objScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(objScale.x/magnify,  objScale.y/magnify, objScale.z/magnify);
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

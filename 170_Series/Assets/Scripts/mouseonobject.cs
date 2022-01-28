using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseonobject : MonoBehaviour
{
    public GameObject clock;
    public GameObject Phone;
    public GameObject CamButtonUI;

    public float magnify;
    public bool Abletoclick;

    public GameObject NewsText;

    void Update(){
        Abletoclick = GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change;
    }

    void OnMouseEnter(){
        if(Abletoclick){
            effectOn();
        }
    }

    void OnMouseDown (){
        if(Abletoclick){
            interaction();
            effectOff();
        }
    }

    void OnMouseExit(){
        if(Abletoclick){
            effectOff();
        }
    }

    private void interaction(){
        if(Abletoclick){
            if(gameObject.name == "item 1"){
                Debug.Log("Desk");
                lock_item_click();
                changecamera("Camera_wardrobe");

            }else if(gameObject.name == "item 2"){
                Debug.Log("Coffee table");
                lock_item_click();
                Phone.SetActive(true);
            }else if(gameObject.name == "item 3"){
                Debug.Log("Wardrobe");
                lock_item_click();
                changecamera("Camera_wardrobe");
            }else if(gameObject.name == "item 4"){
                Debug.Log("Time");
                lock_item_click();
                clock.SetActive(true);
            }else if(gameObject.name == "item 5"){
                Debug.Log("Calendar");
                lock_item_click();
                changecamera("Camera_clendar");
           }else if(gameObject.name == "item 6"){
                Debug.Log("Newspaper");
                lock_item_click();
                changecamera("Camera_newspaper");
                NewsText.SetActive(true);
                //textAppear();
            }else{

            }
        }



    }

    private void lock_item_click(){
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = false;
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

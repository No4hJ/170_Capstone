using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jacketAndTicketScript : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject bigJacket;
    public GameObject TicketText;
    public GameObject blackCover;
    public GameObject ticket;
    public GameObject filter;
    public GameObject LargeTicket;
    

    private float magnify = 1.3f;

    void Start(){
        
    }

     void OnMouseEnter(){
        effectOn();
    }

    void OnMouseExit(){
        effectOff();
    }

    void OnMouseDown ()
    {
        if (gameObject.name == "ticket"){
            
            TicketText.SetActive(true);
            LargeTicket.SetActive(true);
            blackCover.SetActive(true);
            Debug.Log("ticket");
            filter.SetActive(false);
            if (Global.ticketState == 0){
                Global.ticketState = 1;
            }
            
        }
        else if (gameObject.name == "exitSquare" || gameObject.name == "blackCover" ){
            //GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
            
            TicketText.SetActive(false);
            LargeTicket.SetActive(false);
            blackCover.SetActive(false);
            //bigJacket.SetActive(false);
            //ticket.SetActive(false);
            filter.SetActive(true);
            //Debug.Log("BGC");
            //Camera cam2 = GameObject.Find("Camera_wardrobe").GetComponent<Camera>();
            //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
            //cam2.enabled = false;
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


}

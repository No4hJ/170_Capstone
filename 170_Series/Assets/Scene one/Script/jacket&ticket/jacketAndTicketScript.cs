using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jacketAndTicketScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bigJacket;
    public GameObject TicketText;
    public GameObject blackCover;
    public GameObject ticket;

    private float magnify = 1.3f;

     void OnMouseEnter(){
        effectOn();
    }

    void OnMouseExit(){
        effectOff();
    }

    void OnMouseDown ()
    {
        if (gameObject.name == "jacket")
        {
            //GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
            //newspaperParent.SetActive(false);
            bigJacket.SetActive(true);
            ticket.SetActive(true);
            Debug.Log("jacket");
        }else if (gameObject.name == "ticket"){
            TicketText.SetActive(true);
            blackCover.SetActive(true);
            Debug.Log("ticket");
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x/magnify,  objScale.y/magnify, objScale.z/magnify);
        }else if (gameObject.name == "blackCover"){
            //GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
            TicketText.SetActive(false);
            blackCover.SetActive(false);
            bigJacket.SetActive(false);
            ticket.SetActive(false);
            Debug.Log("BGC");
            //Camera cam2 = GameObject.Find("Camera_wardrobe").GetComponent<Camera>();
            //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
            //cam2.enabled = false;
        }
    }

    private void effectOn(){
        if (gameObject.name != "bigJacket" && !blackCover.activeSelf){
            //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.white);
            gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",1);
            //Change Scale
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
            //Debug.Log("effectOn");
        }
    }

    private void effectOff(){
        
        if (gameObject.name != "bigJacket" && !blackCover.activeSelf){
            gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",0);
            //Change Scale
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x/magnify,  objScale.y/magnify, objScale.z/magnify);    
        }
    }


}

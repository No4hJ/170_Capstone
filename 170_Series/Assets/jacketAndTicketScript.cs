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

}

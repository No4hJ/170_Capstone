using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneQuit : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Quit;
    //public GameObject Quit2;
    public GameObject Ls_folder;
    public GameObject Ms_floder;
    public GameObject Chat;


    void Start()
    {
    
    }
    
    void OnMouseDown (){
        interaction();
    }

    void OnMouseEnter(){
        Debug.Log("phone1");
    }
    public void interaction(){
        if(gameObject.name == "Quit"){
            Debug.Log("phone2");
            turnoffphone();
        }

        if(gameObject.name == "Ls_folder"){
            turnonphone();
        }

    }

    public void turnoffphone(){
        turnonphone();
        Debug.Log("here");
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
        Ls_folder.SetActive(true);
        GameObject.Find("Phone").GetComponent<PhoneReference>().CloseAll();
        Phone.SetActive(false);
    }

    public void turnonphone(){
        GameObject.Find("Phone").GetComponent<PhoneReference>().Referenceobject();
        Ls_folder.SetActive(false);
        Ms_floder.SetActive(true);
        
    }

    public void ChatOpen(){
        Debug.Log("chatopen1");
        Chat.SetActive(true);
        Ms_floder.SetActive(false);
        GameObject.Find("Phone").GetComponent<PhoneReference>().Referenceobject();
    }

}

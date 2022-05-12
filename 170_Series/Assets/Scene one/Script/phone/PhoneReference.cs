using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneReference : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Quit;
    //public GameObject Quit2;
    public GameObject Ls_folder;
    public GameObject Ms_floder;
    public GameObject Chat_floder;
    public GameObject Music_floder;
    void Start(){
        Phone = this.gameObject;
        Quit = this.gameObject.transform.GetChild(0).gameObject;
        //Quit2 = this.gameObject.transform.GetChild(1).gameObject;
        Ls_folder = this.gameObject.transform.GetChild(1).gameObject;
        Ms_floder = this.gameObject.transform.GetChild(2).gameObject;
        Chat_floder = this.gameObject.transform.GetChild(3).gameObject;
        Music_floder = this.gameObject.transform.GetChild(4).gameObject;
        Referenceobject();

        CloseAll();
        //Phone.SetActive(false);
        
    }
    public void Referenceobject(){
        PhoneQuit[] allphoneobject = GameObject.FindObjectsOfType<PhoneQuit>();
        
        for(int i = 0; i < allphoneobject.Length; i++){
            allphoneobject[i].GetComponent<PhoneQuit>().Phone = this.Phone;
            allphoneobject[i].GetComponent<PhoneQuit>().Quit = this.Quit;
            //allphoneobject[i].GetComponent<PhoneQuit>().Quit2 = this.Quit2;
            allphoneobject[i].GetComponent<PhoneQuit>().Ls_folder = this.Ls_folder;
            allphoneobject[i].GetComponent<PhoneQuit>().Ms_floder = this.Ms_floder;
            allphoneobject[i].GetComponent<PhoneQuit>().Chat = this.Chat_floder;
            allphoneobject[i].GetComponent<PhoneQuit>().Music = this.Music_floder;
            }
    }

    public void CloseAll(){
        
        Quit.SetActive(true);
        //Quit2.SetActive(true);
        Ls_folder.SetActive(true);
        Ms_floder.SetActive(false);
        Chat_floder.SetActive(false);
        Music_floder.SetActive(false);
    }
}

    

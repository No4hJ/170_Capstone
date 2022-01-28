using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneQuit2 : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Quit;
    public GameObject Quit2;
    public GameObject Ls_folder;
    public GameObject Ms_floder;
    public GameObject Chat;
    void Start(){
        Phone = this.gameObject;
        Quit = this.gameObject.transform.GetChild(0).gameObject;
        Quit2 = this.gameObject.transform.GetChild(1).gameObject;
        Ls_folder = this.gameObject.transform.GetChild(2).gameObject;
        Ms_floder = this.gameObject.transform.GetChild(3).gameObject;

        PhoneQuit[] allphoneobject = GameObject.FindObjectsOfType<PhoneQuit>();
        for(int i = 0; i < allphoneobject.Length; i++){
            allphoneobject[i].GetComponent<PhoneQuit>().Phone = this.Phone;
            allphoneobject[i].GetComponent<PhoneQuit>().Quit = this.Quit;
            allphoneobject[i].GetComponent<PhoneQuit>().Quit2 = this.Quit2;
            allphoneobject[i].GetComponent<PhoneQuit>().Ls_folder = this.Ls_folder;
            allphoneobject[i].GetComponent<PhoneQuit>().Ms_floder = this.Ms_floder;

        }
    }

    void OnMouseDown (){
        interaction();
    }

    void OnMouseEnter(){
        Debug.Log("phone");
    }
    private void interaction(){
        if(gameObject.name == "Quit" || gameObject.name == "Quit2"){
            Debug.Log("phone");
            turnoffphone();
        }

        if(gameObject.name == "Ls_folder"){
            Ls_folder.SetActive(false);
            Ms_floder.SetActive(true);
        }
    }

    private void turnoffphone(){
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
        Ls_folder.SetActive(true);
        Ms_floder.SetActive(false);
        Phone.SetActive(false);
    }
}

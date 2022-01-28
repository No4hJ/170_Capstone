using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneQuit : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Quit;
    public GameObject Quit2;
    public GameObject Ls_folder;
    public GameObject Ms_floder;
    public GameObject Chat;

    void OnMouseDown (){
        interaction();
    }

    void OnMouseEnter(){
        Debug.Log("phone");
    }
    private void interaction(){
        if(gameObject.name == "Quit"){
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

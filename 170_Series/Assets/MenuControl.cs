using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject OptionMenu;
    // Update is called once per frame
    void Start(){
        isPaused = false;
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        OptionMenu.SetActive(false);
        isPaused = false;
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
    }

    public void Pause(){
        OptionMenu.SetActive(true);
        isPaused = true;
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = false;
    }
}

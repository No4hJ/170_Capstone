using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject OptionMenu;
    public GameObject room;
    // Update is called once per frame
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
        room.SetActive(true);
    }

    public void Pause(){
        OptionMenu.SetActive(true);
        isPaused = true;
        room.SetActive(false);
    }
}

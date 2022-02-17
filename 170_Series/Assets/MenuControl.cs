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

    void Resume(){
        OptionMenu.SetActive(false);
        isPaused = false;
        room.SetActive(true);
    }

    void Pause(){
        OptionMenu.SetActive(true);
        isPaused = true;
        room.SetActive(false);
    }
}

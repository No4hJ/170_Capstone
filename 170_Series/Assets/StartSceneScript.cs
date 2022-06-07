using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    public GameObject creditImg;
    public GameObject ButtonExitCredit;

    public GameObject optionMenu;
    public GameObject Sound_notice;
    public GameObject videoPlayer;
    public GameObject bg;
    public GameObject title;
    public GameObject buttons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin(){
        Debug.Log("Begin");
        Sound_notice.SetActive(true);
    }

    public void Option(){
        Debug.Log("Option");
        optionMenu.SetActive(true);
    }

    public void Credit(){
        Debug.Log("Credit");
        //creditImg.SetActive(true);
        videoPlayer.SetActive(true);
        bg.SetActive(false);
        title.SetActive(false);
        buttons.SetActive(false);
        ButtonExitCredit.SetActive(true);
    }

    public void Exit(){
        Debug.Log("Exit");
        Application.Quit();
    }

    public void exitCredit(){
        Debug.Log("Exit Credit");
        //creditImg.SetActive(false);
        videoPlayer.SetActive(false);
        bg.SetActive(true);
        title.SetActive(true);
        buttons.SetActive(true);
        ButtonExitCredit.SetActive(false);
    }
}

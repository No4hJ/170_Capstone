using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    public GameObject creditImg;
    public GameObject ButtonExitCredit;

    public GameObject optionMenu;
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
        SceneManager.LoadScene("Sound_Notice");
    }

    public void Option(){
        Debug.Log("Option");
        optionMenu.SetActive(true);
    }

    public void Credit(){
        Debug.Log("Credit");
        creditImg.SetActive(true);
        ButtonExitCredit.SetActive(true);
    }

    public void Exit(){
        Debug.Log("Exit");
        Application.Quit();
    }

    public void exitCredit(){
        Debug.Log("Exit Credit");
        creditImg.SetActive(false);
        ButtonExitCredit.SetActive(false);
    }
}

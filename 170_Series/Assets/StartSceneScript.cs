using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{
    public GameObject creditImg;
    public GameObject ButtonExitCredit;
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
        SceneManager.LoadScene("game1", LoadSceneMode.Single);
    }

    public void Option(){
        Debug.Log("Option");
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
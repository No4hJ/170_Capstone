using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BackToStart",27.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackToStart()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }
}

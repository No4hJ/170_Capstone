using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidButtonImgControl : MonoBehaviour
{
    public GameObject cameraButton;
    public GameObject camera;
    public GameObject midButton;

    public GameObject finalImg1;
    public GameObject finalImg2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraButton.activeInHierarchy && camera.activeInHierarchy && Global.PuzzleState == 1){
            midButton.SetActive(true);
        }
    }

    public void Switch(){
        if (finalImg1.activeInHierarchy){
            finalImg1.SetActive(false);
            finalImg2.SetActive(true);
        }else{
            finalImg2.SetActive(false);
            finalImg1.SetActive(true);
        }
    }
}

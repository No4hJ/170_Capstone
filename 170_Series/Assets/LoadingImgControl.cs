using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingImgControl : MonoBehaviour
{
    
    private static float waitTimeSet = 2f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
        if (waitTime <= 1){
            gameObject.GetComponent<spriteFade>().FadeImgOut();
        }

        if (waitTime <= -0.02){
            gameObject.SetActive(false);
        }

    }
}

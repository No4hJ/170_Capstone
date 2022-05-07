using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIOControl : MonoBehaviour
{
    // Start is called before the first frame update

    private static float waitTimeSet = 0.3f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;

    public GameObject BlackCover;
    public GameObject Imgs;
    public GameObject Texts;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && waitTime<=0)
        {
            BlackCover.SetActive(false);
            
            for (int i = 0; i < Imgs.transform.childCount; i++)
            {
                Imgs.transform.GetChild(i).gameObject.SetActive(false);
            }

            for (int i = 0; i < Texts.transform.childCount; i++)
            {
                Texts.transform.GetChild(i).gameObject.SetActive(false);
            }

            GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
            gameObject.SetActive(false);
            waitTime = waitTimeSet;
        }
    }

}

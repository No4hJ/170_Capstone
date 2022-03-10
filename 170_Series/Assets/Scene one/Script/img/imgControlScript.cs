using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class imgControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject room;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject imgText;
    public GameObject filter;
    private int imgActive = 0;
    private static float waitTimeSet = 2.0f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      waitTime -= Time.deltaTime;
      //Debug.Log(Time.deltaTime);
        if (Input.GetKeyDown (KeyCode.W) || Global.clockState == 2){
            filter.SetActive(false);
            if (imgActive == 0){
                imgActive = 1;
                img1.SetActive(true);
                room.SetActive(false);
                waitTime = waitTimeSet;
                imgText.SetActive(true);
                Global.clockState = 3;
            }else if (imgActive == 1){
                imgActive = 0;
                room.SetActive(true);
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(false);
                img4.SetActive(false);
                imgText.SetActive(false);
            }


        }

        if (imgActive == 1){
            if (Input.GetMouseButtonDown(0) && waitTime <=0){
			       //Debug.Log("Pressed primary button.");
             if (img1.activeSelf){
               img1.SetActive(false);
               img2.SetActive(true);
               waitTime = waitTimeSet;
             }else if (img2.activeSelf){
               img2.SetActive(false);
               img3.SetActive(true);
               waitTime = waitTimeSet;
             }else if (img3.activeSelf){
               img3.SetActive(false);
               img4.SetActive(true);
               waitTime = waitTimeSet;
             }else if (img4.activeSelf){
               img4.SetActive(false);
               room.SetActive(true);
               SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
             }
		    }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndImgControl : MonoBehaviour
{
    //public GameObject room;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    public GameObject img5;
    public GameObject imgText;
    //public GameObject filter;
    private int imgActive = 0;
    private static float waitTimeSet = 2.0f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;
    void Start()
    {
        imgActive = 1;
        img5.SetActive(true);
        img4.SetActive(true);
        img3.SetActive(true);
        img2.SetActive(true);
        img1.SetActive(true);
                
        waitTime = waitTimeSet;
        imgText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      waitTime -= Time.deltaTime;
        


        if (imgActive == 1){
            if (Input.GetMouseButtonDown(0) && waitTime <=0){
			       //Debug.Log("Pressed primary button.");
             if (img1.activeSelf){
               img1.SetActive(false);
               img2.GetComponent<spriteFade>().FadeImgIn();
               waitTime = waitTimeSet;
             }else if (img2.activeSelf){
               img2.SetActive(false);
               img3.GetComponent<spriteFade>().FadeImgIn();
               waitTime = waitTimeSet;

            }else if (img3.activeSelf){
               img3.SetActive(false);
               img4.GetComponent<spriteFade>().FadeImgIn();
               waitTime = waitTimeSet;
               
             
            }else if (img4.activeSelf){
               img4.SetActive(false);
               img5.GetComponent<spriteFade>().FadeImgIn();
               waitTime = waitTimeSet;
               
            }else if (img5.activeSelf){
               img5.SetActive(false);
               SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
             }
		    }
        }
    }
}

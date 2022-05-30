using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class imgControlScriptS2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject room;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject imgText;
    //public GameObject filter;
    public GameObject clock;
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
        if ((Global.clockStateS2 == 1)||(Input.GetKeyDown("w"))){
            //filter.SetActive(false);
            if (imgActive == 0){
                imgActive = 1;
                img3.SetActive(true);
                img2.SetActive(true);
                img1.SetActive(true);
                room.SetActive(false);
                clock.SetActive(false);
                waitTime = waitTimeSet;
                imgText.SetActive(true);
                Global.clockStateS2 = 2;
            }else if (imgActive == 1){
                imgActive = 0;
                room.SetActive(true);
                clock.SetActive(true);
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(false);
                imgText.SetActive(false);
            }
        }


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
               room.SetActive(true);
               SceneManager.LoadScene("game3", LoadSceneMode.Single);
             }
		    }
        }
    }

}

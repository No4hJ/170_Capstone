using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imgControlScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject room;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public GameObject img4;
    private int imgActive = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.W)){
            if (imgActive == 0){
                imgActive = 1;
                img1.SetActive(true);
                room.SetActive(false);
            }else if (imgActive == 1){
                imgActive = 0;
                room.SetActive(true);
                img1.SetActive(false);
                img2.SetActive(false);
                img3.SetActive(false);
                img4.SetActive(false);
            }
        }

        if (imgActive == 1){
            if (Input.GetMouseButtonDown(0)){
			       //Debug.Log("Pressed primary button.");
             if (img1.activeSelf){
               img1.SetActive(false);
               img2.SetActive(true);
             }else if (img2.activeSelf){
               img2.SetActive(false);
               img3.SetActive(true);
             }else if (img3.activeSelf){
               img3.SetActive(false);
               img4.SetActive(true);
             }else if (img4.activeSelf){
               img4.SetActive(false);
               room.SetActive(true);
             }
		    }
        }
    }
}

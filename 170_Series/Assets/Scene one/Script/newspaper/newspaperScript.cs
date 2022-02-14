using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class newspaperScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newspaperParent;
    public GameObject NewsText;
    public GameObject blackCover;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {

    }

    void OnMouseDown ()
    {
        if (gameObject.name == "leftQuit" || gameObject.name == "rightQuit"|| gameObject.name == "blackCover")
        {
            GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
            newspaperParent.SetActive(false);
            NewsText.SetActive(false);
            blackCover.SetActive(false);
        }else if (gameObject.name == "bigNewspaper"){
            NewsText.SetActive(true);
            blackCover.SetActive(true);
            //Debug.Log(blackCover.activeSelf);
            if ( Global.newspaperState == 0){
                Global.newspaperState = 1;
            }
            //Debug.Log(Global.newspaperState);
        }
    }

}

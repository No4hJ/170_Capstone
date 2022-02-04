using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camback : MonoBehaviour
{
    public string cam_name;
    public GameObject NewsText;
    // Start is called before the first frame update
    public void swtichCam(){
        Camera cam2 = GameObject.Find(cam_name).GetComponent<Camera>();
        //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
        cam2.enabled = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_script : MonoBehaviour
{

    public GameObject Music_list;

    public AudioSource music1;
    public AudioSource music2;

    // Start is called before the first frame update
    void Start()
    {
        Music_list = this.gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Music1(){
        
        Debug.Log("music1 on");
        music1.Play();
        music2.Stop();
    }

    public void Music2(){
        Debug.Log("music2 on");
        music2.Play();
        music1.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_script : MonoBehaviour
{

    public GameObject Music_list;

    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource music4;
    public AudioSource music5;

    [SerializeField] public Text title;

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
        music3.Stop();
        music4.Stop();
        music5.Stop();
        title.text = "Yea";
        
    }

    public void Music2(){
        Debug.Log("music2 on");
        music2.Play();
        music1.Stop();
        music3.Stop();
        music4.Stop();
        music5.Stop();
        title.text = "Sure";
    }
    public void Music3(){
        Debug.Log("music3 on");
        music3.Play();
        music1.Stop();
        music2.Stop();
        music4.Stop();
        music5.Stop();
        title.text = "Alright";
    }
    public void Music4(){
        Debug.Log("music4 on");
        music4.Play();
        music1.Stop();
        music2.Stop();
        music3.Stop();
        music5.Stop();
        title.text = "Mhm";
    }
    public void Music5(){
        Debug.Log("music5 on");
        music5.Play();
        music1.Stop();
        music2.Stop();
        music3.Stop();
        music4.Stop();
        title.text = "Whatever";
    }
    public void MusicStop(){
        music1.Stop();
        music2.Stop();
        music3.Stop();
        music4.Stop();
        music5.Stop();
    }
}

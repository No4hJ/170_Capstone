using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe_Sound : MonoBehaviour
{
    public AudioSource button_click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButton()
    {
        button_click.Play();
    }
}

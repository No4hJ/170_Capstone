using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spriteFade : MonoBehaviour
{
    // Start is called before the first frame update
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("w")){
            StartCoroutine(FadeOut());
        }

        if(Input.GetKeyDown("e")){
            StartCoroutine(FadeIn());
        }

    }

    public void FadeImgOut(){
        //image.color = new Color(1, 1, 1, 1); 
        StartCoroutine(FadeOut());
    }

    public void FadeImgIn(){
        //image.color = new Color(1, 1, 1, 0); 
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeOut(){
        for (float i = 1; i>= 0;i -=Time.deltaTime){
            image.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }

    IEnumerator FadeIn(){
        for (float i = 0; i<= 1;i +=Time.deltaTime){
            image.color = new Color(1, 1, 1, i);
            yield return null;
        }
    }

    
}

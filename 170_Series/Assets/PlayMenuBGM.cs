using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuBGM : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource BGM;
    void Start()
    {
        StartCoroutine(PlayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Crescendo(AudioSource audio, float finalVolume){
        for (float v = 0; v <= finalVolume; v+= 0.05f){
            audio.volume = v;
        }
    }

    IEnumerator PlayBGM()
    {
        yield return new WaitForSeconds(2);
        BGM.Play();
        Crescendo(BGM, 0.4f);
        Debug.Log ("Play BGM");
    }
}

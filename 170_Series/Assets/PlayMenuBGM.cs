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

    IEnumerator PlayBGM()
    {
        yield return new WaitForSeconds(2);
        BGM.Play();
        Debug.Log ("Play BGM");
    }
}

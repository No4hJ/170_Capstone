using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuBGM : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource BGM;
    public AudioSource button_click;
    void Start()
    {
        StartCoroutine(PlayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ButtonClickSound(){
        button_click.Play();
    }
    
    public static IEnumerator Crescendo(AudioSource audio, float duration, float finalVolume)
    {
        float currentTime = 0;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audio.volume = Mathf.Lerp(0, finalVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    public static IEnumerator Diminuendo(AudioSource audio, float duration)
    {
        float currentTime = 0;
        float start = audio.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audio.volume = Mathf.Lerp(start, 0, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    IEnumerator PlayBGM()
    {
        yield return new WaitForSeconds(2);
        BGM.Play();
        StartCoroutine(Crescendo(BGM, 1f, 0.3f));
    }

    public void TransitOut()
    {
        StartCoroutine(Diminuendo(BGM, 0.7f));
    }
}

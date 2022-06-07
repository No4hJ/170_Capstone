using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAmbience_lvl2 : MonoBehaviour
{
    public AudioSource ambience;
    // Start is called before the first frame update
    void Start()
    {
        ambience.Play();
        StartCoroutine(Crescendo(ambience, 0.5f, 0.04f));
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.clockStateS2 == 2){
            StartCoroutine(Diminuendo(ambience, 0.5f));
            ambience.Stop();
        }
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
}

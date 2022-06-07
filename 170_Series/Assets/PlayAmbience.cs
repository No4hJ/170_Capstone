using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAmbience : MonoBehaviour
{
    public AudioSource ambience;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Crescendo(ambience, 0.5f, 0.04f));
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Sound_Xiaoxiaole : MonoBehaviour
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

    IEnumerator PlayBGM()
    {
        yield return new WaitForSeconds(0.5f);
        BGM.Play();
        StartCoroutine(Crescendo(BGM, 1f, 0.3f));
    }
}

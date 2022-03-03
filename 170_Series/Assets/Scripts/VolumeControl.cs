using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private Text UIText = null;

    public float volume_value;

    private void Start()
    {
        setVolume();
    }
    public void VolumeSlide (float volume)
    {
        UIText.text = volume.ToString("0%");
        SaveValue();
    }

    public void SaveValue()
    {
        volume_value = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", volume_value);
        setVolume();
    }
    public void setVolume()
    {   
        volume_value = PlayerPrefs.GetFloat("volume");
        volumeSlider.value = volume_value;
        AudioListener.volume = volumeSlider.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class Calendar_display : MonoBehaviour
{
    
    public GameObject chi;
    public GameObject eng;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
            eng.SetActive(true);
            chi.SetActive(false);
        }

        if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
            eng.SetActive(false);
            chi.SetActive(true);
        }
        
    }
}

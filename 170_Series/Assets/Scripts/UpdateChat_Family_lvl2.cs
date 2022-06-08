using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class UpdateChat_Family_lvl2 : MonoBehaviour
{
    public GameObject en;
    public GameObject chi;
    void Update() {
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                en.SetActive(true);
                chi.SetActive(false);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                en.SetActive(false);
                chi.SetActive(true);         
            }
        }
}

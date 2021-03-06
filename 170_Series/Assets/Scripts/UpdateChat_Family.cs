using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class UpdateChat_Family : MonoBehaviour
{
    public GameObject before_en;
    public GameObject before_chi;
    public GameObject after_en;
    public GameObject after_chi;
    void Update() {
        if (Global.newspaperState >= 1){
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_chi.SetActive(false);
                after_en.SetActive(true);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_chi.SetActive(true);
                after_en.SetActive(false);               
            }
        }
        else{
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(true);
                before_chi.SetActive(false);
                after_chi.SetActive(false);
                after_en.SetActive(false);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(true);
                after_chi.SetActive(false);
                after_en.SetActive(false);               
            }
        }
    }
}

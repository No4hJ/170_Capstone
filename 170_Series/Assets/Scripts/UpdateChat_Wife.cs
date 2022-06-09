using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class UpdateChat_Wife : MonoBehaviour
{
    public GameObject before_en;
    public GameObject before_chi;
    public GameObject after_en;
    public GameObject after_eng;
    public GameObject after_eng1;
    public GameObject after_ch;
    public GameObject after_chi;
    public GameObject after_chi1;
    void Update() {
        if (Global.ticketState >= 1){
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_ch.SetActive(false);
                after_en.SetActive(true);
                after_chi.SetActive(false);
                after_eng.SetActive(true);
                after_chi1.SetActive(false);
                after_eng1.SetActive(true);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_ch.SetActive(true);
                after_en.SetActive(false);
                after_chi.SetActive(true);
                after_eng.SetActive(false);        
                after_chi1.SetActive(true);
                after_eng1.SetActive(false);             
            }
        }
        else{
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(true);
                before_chi.SetActive(false);
                after_ch.SetActive(false);
                after_en.SetActive(false);
                after_chi.SetActive(false);
                after_eng.SetActive(false);
                after_chi1.SetActive(false);
                after_eng1.SetActive(false);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(true);
                after_ch.SetActive(false);
                after_en.SetActive(false);
                after_chi.SetActive(false);
                after_eng.SetActive(false);
                after_chi1.SetActive(false);
                after_eng1.SetActive(false);                                   
            }
        }
    }
}

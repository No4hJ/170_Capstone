using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class UpdateChat_Wife2 : MonoBehaviour
{
    public GameObject before_en;
    public GameObject before_chi;
    public GameObject after_en1;
    public GameObject after_en2;
    public GameObject after_ch1;
    public GameObject after_ch2;
    void Update() {
        if (Global.marriageCertificateState >= 2){
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_ch1.SetActive(false);
                after_ch2.SetActive(false);
                after_en1.SetActive(true);
                after_en2.SetActive(true);
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(false);
                after_ch1.SetActive(true);
                after_ch2.SetActive(true);
                after_en1.SetActive(false);
                after_en2.SetActive(false);                  
            }
        }
        else{
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[0]){
                before_en.SetActive(true);
                before_chi.SetActive(false);
                after_ch1.SetActive(false);
                after_ch2.SetActive(false);
                after_en1.SetActive(false);
                after_en2.SetActive(false);         
            }
            if(LocalizationSettings.SelectedLocale == LocalizationSettings.AvailableLocales.Locales[1]){
                before_en.SetActive(false);
                before_chi.SetActive(true);
                after_ch1.SetActive(false);
                after_ch2.SetActive(false);
                after_en1.SetActive(false);
                after_en2.SetActive(false);                                     
            }
        }
    }
}

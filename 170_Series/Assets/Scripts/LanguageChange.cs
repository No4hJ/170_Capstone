using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;

public class LanguageChange : MonoBehaviour
{
    public GameObject menu;
    public GameObject gameScene;
    public bool ismenu = false;
    public void SetSelectedLocale(Locale locale)
    {
        LocalizationSettings.SelectedLocale = locale;
    }

    public int getLocaleIndex()
    {
        return LocalizationSettings.SelectedLocale.SortOrder;
    }

    public int getLocaleListRange()
    {
        return LocalizationSettings.AvailableLocales.Locales.Count;
    }

    public void swtichLanguageLeft()
    {
            if (getLocaleIndex() == 0)
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleListRange() -1]);
            }
            else
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleIndex() -1]);
            }
    }

        public void swtichLanguageRight()
    {
            if (getLocaleIndex() == getLocaleListRange() -1)
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
            }
            else
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleIndex() +1]);
            }
    }
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.E)){
            if (getLocaleIndex() == 0)
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleListRange() -1]);
            }
            else
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleIndex() -1]);
            }
        }

         if (Input.GetKeyDown(KeyCode.F)){
            if (getLocaleIndex() == getLocaleListRange()-1)
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[0]);
            }
            else
            {
                SetSelectedLocale(LocalizationSettings.AvailableLocales.Locales[getLocaleIndex() +1]);
            }
        }
        Debug.Log(getLocaleIndex());*/

    if (Input.GetKeyDown(KeyCode.Escape)){
        if(!ismenu){
            menu.SetActive(true);
            gameScene.SetActive(false);
            ismenu = true;
        }
        else{
            menu.SetActive(false);
            gameScene.SetActive(true);
            ismenu = false;
        }
        
    }
    }
    
}

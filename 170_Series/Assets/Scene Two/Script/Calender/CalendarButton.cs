using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOnButton()
    {
        for (int i = 0; i <= 2; i++)
        {
            GameObject parentC = transform.parent.gameObject;
            GameObject Month = parentC.transform.GetChild(i).gameObject;
            Month.transform.GetChild(0).gameObject.SetActive(false);
        }
        transform.GetChild(0).gameObject.SetActive(true);
        for (int i = 0; i <= 2; i++)
        {
            GameObject parentC = transform.parent.gameObject;
            GameObject Month = parentC.transform.GetChild(i).gameObject;
            Month.transform.GetChild(1).gameObject.SetActive(true);
        }
        transform.GetChild(1).gameObject.SetActive(false);
    }

    public void ClickOnExit()
    {
        transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
    }
}

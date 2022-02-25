using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject safe;
    public GameObject inside;
    public GameObject safePanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown ()
    {
        
    }

    public void SafeExit()
    {
        safe.SetActive(true);
            inside.SetActive(false);
            safePanel.SetActive(false);
    }
}

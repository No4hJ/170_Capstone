using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlace : MonoBehaviour
{
    private bool allPlaced = false;
    [SerializeField] GameObject finalImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        allPlaced = true;
        for(int i=0; i<6; i++){
            GameObject objFC = transform.GetChild(i).gameObject;
            if (objFC.GetComponent<SpriteRenderer>().color != new Color(0f, 0f, 0f, 0f)){
                 allPlaced = false;
             }
            //Debug.Log(objFC.gameObject.name);
        }

        if (allPlaced)
        {
            //OpenImg();
            Invoke("OpenImg", 3.0f);
        }

        
    }

    void OpenImg()
        {
            finalImg.SetActive(true);
        }
}

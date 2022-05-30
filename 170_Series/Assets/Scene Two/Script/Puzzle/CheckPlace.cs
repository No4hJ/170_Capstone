using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlace : MonoBehaviour
{
    private bool allPlaced = false;
    [SerializeField] GameObject finalImg;
    [SerializeField] GameObject finalImg2;

    public GameObject button;

    public GameObject button1;

    public GameObject final_pic;
    public GameObject frags;
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
            gameObject.SetActive(false);
        }

        
    }

    void OpenImg()
        {
            finalImg.SetActive(true);
            finalImg2.SetActive(true);
            button.SetActive(false);
            button1.SetActive(true);
            if (Global.PuzzleState ==0){
                Global.PuzzleState = 1;
            }
            final_pic.SetActive(true);
            frags.SetActive(false);
        }
}

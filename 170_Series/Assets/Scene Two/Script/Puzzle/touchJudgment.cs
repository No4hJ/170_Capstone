using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchJudgment : MonoBehaviour
{
    // Start is called before the first frame update
    private Color originalColor;
    void Start()
    {
        originalColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        // if (GetComponent<Collider2D>().IsTouching(img1.GetComponent<Collider2D>())){
        //     GetComponent<SpriteRenderer>().color = new Color(1,0,0.3f,1);
        //     Debug.Log("233");
        // }else{
        //     GetComponent<SpriteRenderer>().color = originalColor;
        // }
    }  


    void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.name == "ImgBase1" && collision.gameObject.name == "puzzleImg1")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }else if (gameObject.name == "ImgBase2" && collision.gameObject.name == "puzzleImg2")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }else if (gameObject.name == "ImgBase3" && collision.gameObject.name == "puzzleImg3")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }else if (gameObject.name == "ImgBase4" && collision.gameObject.name == "puzzleImg4")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }else if (gameObject.name == "ImgBase5" && collision.gameObject.name == "puzzleImg5")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }else if (gameObject.name == "ImgBase6" && collision.gameObject.name == "puzzleImg6")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<SpriteRenderer>().color = originalColor;
    }
}

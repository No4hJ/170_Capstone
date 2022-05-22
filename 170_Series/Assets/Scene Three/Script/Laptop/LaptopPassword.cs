using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopPassword : MonoBehaviour
{
    public Text passwordText;
    //string currentValue = "";
    private bool editable = true;
    public string correctPassword = "12345"; // Set Password Here!】
    public static float waitTimeSet = 0.5f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (editable){

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)){
               CheckPassword();
            }
        }
    }

    private void unlock(){
        transform.Find("Password Input").gameObject.SetActive(false);
        transform.Find("OK Button").gameObject.SetActive(false);
        transform.Find("Wrong Text").gameObject.SetActive(false);

        transform.Find("Desktop Img").gameObject.SetActive(true);
        transform.Find("Icons").gameObject.SetActive(true);
        //gameObject.SetActive(false);
    }

    public void CheckPassword(){
        if(passwordText.text == correctPassword){
            unlock();
        }else{
            //passwordText.text = "";
            transform.Find("Wrong Text").gameObject.SetActive(true);
        }
    }
}

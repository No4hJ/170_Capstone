using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopPassword : MonoBehaviour
{
    public Text passwordText;
    string currentValue = "";
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
        passwordText.GetComponent<Text>().text = currentValue;

        // Change Password Here!
        // if (currentValue == correctPassword){
        //     //currentValue = "CORRECT";
        //     editable = false;
        // }

        if (editable){
            if (currentValue.Length >=5){
                //currentValue = "WRONG";
                editable = false;
            }

            if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
            {
                currentValue += "0";
            }else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)){
                currentValue += "1";
            }else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)){
                currentValue += "2";
            }else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)){
                currentValue += "3";
            }else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)){
                currentValue += "4";
            }else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)){
                currentValue += "5";
            }else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6)){
                currentValue += "6";
            }else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7)){
                currentValue += "7";
            }else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8)){
                currentValue += "8";
            }else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9)){
                currentValue += "9";
            }
        }

        if (!editable){
            waitTime -= Time.deltaTime;
            if (waitTime <=0){
                editable = true;
                waitTime = waitTimeSet;
                if(currentValue == correctPassword){
                    unlock();
                }
                currentValue = "";
            }
        }
    }

    private void unlock(){
        transform.Find("Password Text").gameObject.SetActive(false);
        transform.Find("Desktop Img").gameObject.SetActive(true);
        //gameObject.SetActive(false);
    }
}

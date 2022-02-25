using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class safePanel : MonoBehaviour
{
    // Start is called before the first frame update
    public Text passwordText;
    public GameObject safe;
    public GameObject inside;
    string currentValue = "";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passwordText.text = currentValue;

        // Change Password Here!
        if (currentValue == "1234"){
            safe.SetActive(false);
            inside.SetActive(true);
            gameObject.SetActive(false);
        }

        if (currentValue.Length >=4){
            currentValue = "";
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

    public void AddWord(string digit){
        currentValue += digit;
        //Debug.Log(digit);
    }
}

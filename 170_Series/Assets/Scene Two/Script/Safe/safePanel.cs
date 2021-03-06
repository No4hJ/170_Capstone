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
    private static float waitTimeSet = 0.6f; // Set Wait Time Here!
    private float waitTime = waitTimeSet;
    private bool editable = true;
    private string correctPassword = "0818"; // Set Password Here!
    
    public AudioSource error_sound;
    public AudioSource door_open;
    public bool isPlayed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passwordText.text = currentValue;

        // Change Password Here!
        // if (currentValue == correctPassword){
        //     //currentValue = "CORRECT";
        //     editable = false;
        // }

        if (editable){
            if (currentValue.Length >=4){
                //currentValue = "WRONG";
                editable = false;
                isPlayed = false;
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

            if(currentValue != correctPassword && waitTime <= waitTimeSet/2f){
                if(!isPlayed)
                {
                    error_sound.Play();
                    isPlayed = true;
                }
                
                currentValue = "Error";
            }

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

    public void AddWord(string digit){
        if (editable){
            currentValue += digit;
        }

        //Debug.Log(digit);
    }
    public void DelWord(string digit){
        if (editable && currentValue.Length>=1){
            currentValue = currentValue.Remove(currentValue.Length - 1, 1);
        }
        //Debug.Log(digit);
    }

    private void unlock(){
        door_open.Play();
        safe.SetActive(false);
        inside.SetActive(true);
        gameObject.SetActive(false);
    }
}

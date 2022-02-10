using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconCollider : MonoBehaviour
{
    void OnMouseDown (){
        interaction();
    }
    private void interaction(){
        if(gameObject.name == "Chat"){
            Chat();
        }

        if(gameObject.name == "Web"){
            Debug.Log("Web");
        }

        if(gameObject.name == "Video"){
            Debug.Log("Video");
        }
        if(gameObject.name == "Setting"){
            Debug.Log("Setting");
        }
        if(gameObject.name == "Cloud"){
            Debug.Log("Cloud");
        }

    }
    public void Chat(){
        Debug.Log("chatopen");
        GameObject.Find("Quit").GetComponent<PhoneQuit>().ChatOpen();
    }

    public void Web(){

    }

    public void Video(){
        
    }

    public void Setting(){
        
    }

    public void Cloud(){
        
    }
}

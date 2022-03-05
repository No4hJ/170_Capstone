using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat_script : MonoBehaviour
{
    public GameObject People_chat_list;
    public GameObject chat_text;

    // Start is called before the first frame update
    void Start()
    {
        People_chat_list = this.gameObject.transform.GetChild(1).gameObject;
        chat_text = this.gameObject.transform.GetChild(2).gameObject;
        chat_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void person1_chat(){
        Chat_text_active(1);
        Global.person1ChatState = 1;
    }
    public void person2_chat(){
        Chat_text_active(2);
        Global.person2ChatState = 1;
    }

    private void Chat_text_active(int n){
        People_chat_list.SetActive(false);
        chat_text.SetActive(true);
        GameObject Chat = chat_text.transform.GetChild(n-1).gameObject;
        Chat.SetActive(true);
    }

    public void reset_chat(){
        int n = chat_text.transform.childCount;
        for(int i = 0; i < n; i++){
            chat_text.transform.GetChild(i).gameObject.SetActive(false);
            }
        People_chat_list.SetActive(true);
    }
}

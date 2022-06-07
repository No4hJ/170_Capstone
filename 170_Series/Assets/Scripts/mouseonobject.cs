using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseonobject : MonoBehaviour
{
    public GameObject clock;
    public GameObject Phone;
    public GameObject CamButtonUI;

    public float magnify;
    public bool Abletoclick;

    public GameObject newspaperParent;
    public GameObject notify;
    public GameObject calimg;
    

    public AudioSource newspaper_open;
    public AudioSource interaction_sound;

    public Texture2D cursor1;
    public Texture2D cursor2;


    void Update(){
        Abletoclick = GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change;
    }

    void OnMouseEnter(){
        if(Abletoclick){
            //Cursor.visible = false;

            effectOn();
            Cursor.SetCursor(cursor2,Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    void OnMouseDown (){
        if(Abletoclick){
            effectOff();
            interaction();
            Cursor.SetCursor(cursor1,Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    void OnMouseExit(){
        if(Abletoclick){
            effectOff();
            Cursor.SetCursor(cursor1,Vector2.zero, CursorMode.ForceSoftware);
        }
    }

    private void interaction(){
        if(Abletoclick){
            if(gameObject.name == "item 1"){
                Debug.Log("Desk");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_table");

            }else if(gameObject.name == "item 2"){
                Debug.Log("Phone");
                interaction_sound.Play();
                lock_item_click();
                Phone.SetActive(true);
                if (notify.GetComponent<Renderer>().enabled == true){
                    notify.GetComponent<Renderer>().enabled = false;
                }
                //if (Global.ticketState == 2){
                //    Global.ticketState = 3;
                //}

                //if (Global.newspaperState == 2){
                //    Global.newspaperState = 3;
                //}
            }else if(gameObject.name == "clothes")
            {
                Debug.Log("Wardrobe");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_wardrobe");
            }else if(gameObject.name == "item 4"){
                Debug.Log("Time");
                interaction_sound.Play();
                if (Global.person1ChatState == 1 && Global.person2ChatState == 1 && Global.clockState == 0){
                    Global.clockState = 1;
                }
                lock_item_click();
                clock.SetActive(true);
            }else if(gameObject.name == "item 5"){
                Debug.Log("Calendar");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_clendar");
                calimg.SetActive(true);
           }else if(gameObject.name == "item 6"){
                //Debug.Log(Global.newspaperState);
                lock_item_click();
                //changecamera("Camera_newspaper");
                //newspaperParent.SetActive(true);
                newspaper_open.Play();
                //Vector3 objScale = gameObject.transform.localScale;
                //gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
                //newspaperBackground.SetActive(false);

                //lock_item_click();
                //bigNewspaper.SetActive(false);
                //changecamera("Camera_newspaper");
                //NewsText.SetActive(true);
                //newspaperBackground.SetActive(true);
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("NewsPaper").gameObject.SetActive(true);
                t.transform.Find("NewsPaper").gameObject.SetActive(true);

                if ( Global.newspaperState == 0){
                    Global.newspaperState = 1;
                }
            }else if (gameObject.name == "notes"){
                Debug.Log("notes");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("Notes").gameObject.SetActive(true);
                t.transform.Find("Notes").gameObject.SetActive(true);
            }
            else if (gameObject.name == "boxes")
            {
                Debug.Log("boxes");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("Boxes").gameObject.SetActive(true);
                t.transform.Find("Boxes").gameObject.SetActive(true);
            }
            else if (gameObject.name == "trashcan")
            {
                Debug.Log("trashcan");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("TrashCan").gameObject.SetActive(true);
                t.transform.Find("TrashCan").gameObject.SetActive(true);
            }
            else if (gameObject.name == "drinks")
            {
                Debug.Log("drinks");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("Drinks").gameObject.SetActive(true);
                t.transform.Find("Drinks").gameObject.SetActive(true);
            }
            else if (gameObject.name == "bottomboxes")
            {
                Debug.Log("bottomboxes");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("BottomBoxes").gameObject.SetActive(true);
                t.transform.Find("BottomBoxes").gameObject.SetActive(true);
            }
            else
            {

            }
        }



    }

    private void lock_item_click(){
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = false;
    }

    private void effectOn(){
          if (gameObject.name != "bigNewspaper") {
            //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.white);
            gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",1);
            //Change Scale
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
            //Debug.Log("effectOn");
          }

    }

    private void effectOff(){
        if (gameObject.name != "bigNewspaper") {
          gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",0);
          //Change Scale
          Vector3 objScale = gameObject.transform.localScale;
          gameObject.transform.localScale = new Vector3(objScale.x/magnify,  objScale.y/magnify, objScale.z/magnify);
        }
    }

    //changecamera
    private void changecamera(string cam_name){
        GameObject cam_sending = GameObject.Find("Camera");
        cam_sending.GetComponent<Camback>().cam_name = cam_name;
        //Camera cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        Camera cam2 = GameObject.Find(cam_name).GetComponent<Camera>();
        //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
        cam2.enabled = true;
        //if(gameObject.name != "item 3"){
            CamButtonUI.SetActive(true);
        //}
        //CamButtonUI.SetActive(true);
        //aud2.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseonobjectScene2 : MonoBehaviour
{
    public GameObject clock;
    public GameObject Phone;
    public GameObject CamButtonUI;

    public float magnify = 1;
    public bool Abletoclick;

    public GameObject newspaperParent;
    public GameObject notify;

    public AudioSource newspaper_open;
    public AudioSource interaction_sound;

    public GameObject safe;
    public GameObject FragmentsOnWall;
    public GameObject PuzzleImgs;

    public GameObject CalendarUI;
    public Texture2D cursor1;
    public Texture2D cursor2;

    void Update(){
        Abletoclick = GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change;
    }

    void OnMouseEnter(){
        if(Abletoclick){
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
                lock_item_click();
                changecamera("Camera_table");

            }else if(gameObject.name == "item 2"){
                //Debug.Log(Global.marriageCertificateState);
                interaction_sound.Play();
                lock_item_click();
                if (Global.marriageCertificateState == 1){
                    //Debug.Log("P2");
                    Global.marriageCertificateState =2; 
                }
                Phone.SetActive(true);
                if (notify.GetComponent<Renderer>().enabled == true){
                    notify.GetComponent<Renderer>().enabled = false;
                }
            }else if(gameObject.name == "item 3"){
                Debug.Log("Wardrobe");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_wardrobe");
            }else if(gameObject.name == "item 4"){
                Debug.Log("Time");
                lock_item_click();
                clock.SetActive(true);
            }else if(gameObject.name == "item 5"){
                Debug.Log("Calendar");
                interaction_sound.Play();
                lock_item_click();
                CalendarUI.SetActive(true);
                changecamera("Camera_clendar");

           }else if(gameObject.name == "item 6"){
                //Debug.Log(Global.newspaperState);
                lock_item_click();
                //changecamera("Camera_newspaper");
                newspaperParent.SetActive(true);
                newspaper_open.Play();
                //Vector3 objScale = gameObject.transform.localScale;
                //gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
                //newspaperBackground.SetActive(false);

                //lock_item_click();
                //bigNewspaper.SetActive(false);
                //changecamera("Camera_newspaper");
                //NewsText.SetActive(true);
                //newspaperBackground.SetActive(true);
            }else if(gameObject.name == "Drawer"){
                Debug.Log("Drawer");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_drawer");
                safe.SetActive(true);
                
            }else if(gameObject.name == "Puzzle"){
                Debug.Log("Puzzle");
                interaction_sound.Play();
                lock_item_click();
                changecamera("Camera_puzzle");
            }else if (gameObject.name == "trashcan")
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
                //t.transform.Find("TrashCan").gameObject.SetActive(true);

                GameObject ifg = GameObject.Find("imageFragments");
                GameObject ifgow = GameObject.Find("imageFragmentsOnWall");
                if  (!ifgow.transform.Find("fragmentOnWall1").gameObject.activeSelf){
                    ifg.transform.Find("Fragment1").gameObject.SetActive(true);
                    t.transform.Find("TrashCan").gameObject.SetActive(true);
                }else{
                    t.transform.Find("TrashCanS1").gameObject.SetActive(true);
                }

            }else if (gameObject.name == "bottomboxes")
            {
                Debug.Log("trashcan");
                interaction_sound.Play();
                lock_item_click();
                GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
                GameObject i = SIO.transform.Find("Imgs").gameObject;
                GameObject t = SIO.transform.Find("Texts").gameObject;
                SIO.transform.Find("BlackCover").gameObject.SetActive(true);
                SIO.transform.Find("SIOControl").gameObject.SetActive(true);
                i.transform.Find("BottomBoxes").gameObject.SetActive(true);
                //t.transform.Find("BottomBoxes").gameObject.SetActive(true);

                GameObject ifg = GameObject.Find("imageFragments");
                GameObject ifgow = GameObject.Find("imageFragmentsOnWall");
                if  (!ifgow.transform.Find("fragmentOnWall4").gameObject.activeSelf){
                    ifg.transform.Find("Fragment4").gameObject.SetActive(true);
                    t.transform.Find("BottomBoxes").gameObject.SetActive(true);
                }else{
                    t.transform.Find("BottomBoxesS1").gameObject.SetActive(true);
                }
            
            }else{
                if (transform.parent.name == "imageFragments")
                {
                    fragmentInteract();
                }
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

    private void fragmentInteract()
    {
        gameObject.SetActive(false);

        if (gameObject.name == "Fragment1")
        {
            Debug.Log("Frgmt1");
            FragmentsOnWall.transform.GetChild(0).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (gameObject.name == "Fragment2"){
            Debug.Log("Frgmt2");
            FragmentsOnWall.transform.GetChild(1).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (gameObject.name == "Fragment3"){
            Debug.Log("Frgmt3");
            FragmentsOnWall.transform.GetChild(2).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (gameObject.name == "Fragment4"){
            Debug.Log("Frgmt4");
            FragmentsOnWall.transform.GetChild(3).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (gameObject.name == "Fragment5"){
            Debug.Log("Frgmt5");
            FragmentsOnWall.transform.GetChild(4).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(4).gameObject.SetActive(true);
        }
        else if (gameObject.name == "Fragment6"){
            Debug.Log("Frgmt6");
            FragmentsOnWall.transform.GetChild(5).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(5).gameObject.SetActive(true);
        }
    }
}

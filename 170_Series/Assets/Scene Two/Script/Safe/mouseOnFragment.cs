using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOnFragment : MonoBehaviour
{
    [SerializeField] float magnify = 1.13f;
    public GameObject FragmentsOnWall;
    public GameObject PuzzleImgs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter(){
        effectOn();
    }

    void OnMouseExit(){
        effectOff();
    }

    void OnMouseDown ()
    {
        if (gameObject.name == "Fragment6"){
            Debug.Log("Frgmt6");
            FragmentsOnWall.transform.GetChild(5).gameObject.SetActive(true);
            PuzzleImgs.transform.GetChild(5).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void effectOn(){
        
            //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.white);
            gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",1);
            //Change Scale
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x*magnify,  objScale.y*magnify, objScale.z*magnify);
            //Debug.Log("effectOn");
        
    }

    private void effectOff(){
        
        
            gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",0);
            //Change Scale
            Vector3 objScale = gameObject.transform.localScale;
            gameObject.transform.localScale = new Vector3(objScale.x/magnify,  objScale.y/magnify, objScale.z/magnify);    
        
    }

    public void SetCamera(){
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
        Global.marriageCertificateState = 1;
    }
}

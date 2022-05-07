using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOnMC : MonoBehaviour
{
    // Start is called before the first frame update
    private float magnify = 1.13f;
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
        if (gameObject.name == "marriageCertificate"){
            
            Debug.Log("MC");
            
            GameObject SIO = GameObject.Find("SimpleInteractiveObjects");
            GameObject i = SIO.transform.Find("Imgs").gameObject;
            GameObject t = SIO.transform.Find("Texts").gameObject;
            SIO.transform.Find("BlackCover").gameObject.SetActive(true);
            SIO.transform.Find("SIOControl").gameObject.SetActive(true);
            i.transform.Find("MarriageCertificate").gameObject.SetActive(true);
            t.transform.Find("MarriageCertificate").gameObject.SetActive(true);
            //GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = true;
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

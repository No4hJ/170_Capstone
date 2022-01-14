using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContourFor3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
       //Debug.Log(Shader.IsKeywordEnabled("_OutlineEnabled"));
       //mat.EnableKeyword("Outline Enabled");
       //Shader.EnableKeyword("_OutlineEnabled");
       //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.red);
       //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_SolidOutline",Color.black);
       gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",1);
    }
    void OnMouseExit()
    {
       //Debug.Log("Exit");
       //gameObject.GetComponent<Renderer>().sharedMaterial.SetColor("_Color",Color.white);
       gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_OutlineEnabled",0);
    }
}

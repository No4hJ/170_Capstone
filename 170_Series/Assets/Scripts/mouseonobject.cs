using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseonobject : MonoBehaviour
{
    public GameObject clock;
    public GameObject Phone;
    public GameObject CamButtonUI;

    public float magnify = 1.15f;
    public bool Abletoclick;

    public Text News;

    void Update(){
        Abletoclick = GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change;
    }

    void OnMouseEnter(){
        if(Abletoclick){
            effectOn();
        }
    }

    void OnMouseDown (){
        if(Abletoclick){
            interaction();
            effectOff();
        }
    }

    void OnMouseExit(){
        if(Abletoclick){
            effectOff();
        }
    }

    private void interaction(){
        if(Abletoclick){
            if(gameObject.name == "item 1"){
                Debug.Log("Desk");
                lock_item_click();
                changecamera("Camera_wardrobe");

            }else if(gameObject.name == "item 2"){
                Debug.Log("Coffee table");
                lock_item_click();
                Phone.SetActive(true);
            }else if(gameObject.name == "item 3"){
                Debug.Log("Wardrobe");
                lock_item_click();
                changecamera("Camera_wardrobe");
            }else if(gameObject.name == "item 4"){
                Debug.Log("Time");
                lock_item_click();
                clock.SetActive(true);
            }else if(gameObject.name == "item 5"){
                Debug.Log("Calendar");
                lock_item_click();
                changecamera("Camera_clendar");
            }else{

            }
        }
        
        

    }

    private void lock_item_click(){
        GameObject.Find("Background").GetComponent<cameraswitch>().Camera_can_change = false;
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

    private void textAppear(){
      //GameObject cam_sending = GameObject.Find("Camera");
      //if (cam_sending.GetComponent<Camback>().cam_name == "Camera_newspaper"){
        News.text = @"报纸标题：阳间早报
日期：2018年10月26日
天气：多云，12-22℃， 西北风3-4级
头条：突发！八大道东出口与兴韦路十字路口连环车祸致5死3伤
昨日，10月25日（周四）晚8点30分，位于八大道东出口与兴韦路十字路口的人行道出发生了一起三辆轿车的连环车祸，导致后两车的司机当场身亡，前车司机与副驾乘客不同程度受伤。
根据道路监控摄像头显示，前车系红灯正常靠线停泊等待红绿灯，被后车高速冲撞后由惯性撞入人行道中，导致位于人行道上绿灯照常行走的4名路人3人当场身亡，1人重伤。
具警方初步调查，尾车司机系酒驾超速行驶，中间车辆在正常减速停驶时被后车高速冲撞并撞至前车，导致前车再由惯性撞入人行走道。
身亡的3位路人包括一名27岁青年女性以及一位75岁高龄奶奶及其6岁的孙子。具体事故责任赔偿方以及赔偿方式等请有待后续消息。

电竞：英雄联盟S8赛季全球总决赛半决赛 IG迎战G2 谁将率先进入总决赛？
        ";
    }

    //changecamera
    private void changecamera(string cam_name){
        GameObject cam_sending = GameObject.Find("Camera");
        cam_sending.GetComponent<Camback>().cam_name = cam_name;
        //Camera cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        Camera cam2 = GameObject.Find(cam_name).GetComponent<Camera>();
        //AudioListener aud2 = GameObject.Find(cam_name).GetComponent<AudioListener>();
        cam2.enabled = true;
        CamButtonUI.SetActive(true);
        //aud2.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{
    public bool Camera_can_change = true;
    public void change(){
        Camera_can_change = !Camera_can_change;
    }
}

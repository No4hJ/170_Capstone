using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateChat : MonoBehaviour
{
    public GameObject before;
    public GameObject after;
    void Update() {
        if (Global.newspaperState >= 1){
            before.SetActive(false);
            after.SetActive(true);
        }
        else{
            before.SetActive(true);
            after.SetActive(false);
        }
    }
}

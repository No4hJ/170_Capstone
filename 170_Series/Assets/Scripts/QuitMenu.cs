using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu : MonoBehaviour
{
    public GameObject optionMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            optionMenu.SetActive(false);
        }
    }
}

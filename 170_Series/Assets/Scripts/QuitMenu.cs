using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu : MonoBehaviour
{
    public GameObject optionMenu;

    public void LeaveMenu()
    {
        optionMenu.SetActive(false);
    }
            
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick1 : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton(){
        GlobalWasteTime.TimeWasteCount += 1; 
        Debug.Log("Button Clicked");
    }
}

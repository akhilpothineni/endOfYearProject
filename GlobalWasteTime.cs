using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalWasteTime : MonoBehaviour
{
    public static double TimeWasteCount = 0;
    public GameObject TimeWasteDisplay;
    public double InternalTimeWaste;
    private int Frames = 0;


    // Update is called once per frame
    void Update(){
        Frames++;
        if (Frames % PassiveIncrease.PassiveIncreaseRate == 0){
            TimeWasteCount += UpgradePassiveValue.UpgradeValueLevel-1; //need to add upgrade to increase this amount
        }
        InternalTimeWaste = TimeWasteCount;
        TimeWasteDisplay.GetComponent<Text>().text = "Time Wasted: " + InternalTimeWaste;
    }
}

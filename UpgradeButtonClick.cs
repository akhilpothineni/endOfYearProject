using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButtonClick : MonoBehaviour
{
    public GameObject ProcrastinationButton;

    public void IsItReady(){
        if (GlobalWasteTime.TimeWasteCount >= PassiveIncrease.UpgradeCost)
        {
            GlobalWasteTime.TimeWasteCount -= PassiveIncrease.UpgradeCost;
            PassiveIncrease.PassiveIncreaseRate -= 10;
            PassiveIncrease.UpgradeLevel += 1; 
            Debug.Log("Upgrade Level = " + PassiveIncrease.UpgradeLevel);           
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePassiveButton : MonoBehaviour
{
    public GameObject ProcrasinationButtonValue;

    public void AreWeGood(){
        if (GlobalWasteTime.TimeWasteCount >= UpgradePassiveValue.UpgradeValueCost)
        {
            GlobalWasteTime.TimeWasteCount -= UpgradePassiveValue.UpgradeValueCost;
            UpgradePassiveValue.UpgradeValueLevel++;
            Debug.Log("Upgrade Level = " + UpgradePassiveValue.UpgradeValueLevel);
        }
    }
}

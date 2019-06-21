using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveIncrease : MonoBehaviour
{
    public static int UpgradeLevel = 1;
    public static int UpgradeCost = 0;
    public static int PassiveIncreaseRate = 500; //inverse to what is actually happening, as it is used to count frames
    public GameObject ProcrasinationCostDisplay;
    public int InternalUpgradeCost;


    // Update is called once per frame
    void Update()
    {
        UpgradeCost = 10*UpgradeLevel;
        InternalUpgradeCost = UpgradeCost;
        ProcrasinationCostDisplay.GetComponent<Text>().text = "Procrastination Cost: " + InternalUpgradeCost;
    }
}

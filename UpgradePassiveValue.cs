using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePassiveValue : MonoBehaviour
{
    public GameObject PassiveIncreaseValueDisplay;
    public static int UpgradeValueCost = 0;
    public static int UpgradeValueLevel = 1;
    public int InternalValueCost;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpgradeValueCost = 10*UpgradeValueLevel;
        InternalValueCost = UpgradeValueCost;
        PassiveIncreaseValueDisplay.GetComponent<Text>().text = "Procrastination Value: " + InternalValueCost;
    }
}

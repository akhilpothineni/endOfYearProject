using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In : MonoBehaviour
{
    public GameObject ClockObject;
    
    public void AddObject(){
        Instantiate(ClockObject);
    }
}
    
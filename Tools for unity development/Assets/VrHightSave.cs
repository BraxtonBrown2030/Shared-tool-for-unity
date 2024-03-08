using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class VrHightSave : MonoBehaviour
{
    public UnityEvent setHight;
    public FloatData xrHightSave;
    public float tempHight;
    
    
    void Start()
    {
        xrHightSave.value = tempHight;

        // set hight of XR Camera Offset ot the set high vaule

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
